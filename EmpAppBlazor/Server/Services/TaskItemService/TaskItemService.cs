using AutoMapper;
using EmpAppBlazor.Shared.DTOs;

namespace EmpAppBlazor.Server.Services.TaskItemService
{
    public class TaskItemService : ITaskItemService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public TaskItemService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<TaskItem>>> GetAllTasks()
        {
            var tasks = await _context.TaskItems.Include(x => x.Project).Include(x => x.AssignedTo).ToListAsync();
            var response = new ServiceResponse<List<TaskItem>>
            {
                Data = tasks
            };
            return response;
        }

        public async Task<ServiceResponse<List<TaskItem>>> GetAllTasksByUserId(int userId)
        {
            var tasks = await _context.TaskItems.Include(x => x.Project).Include(x => x.AssignedTo).Where(x => x.AssignedToId == userId).ToListAsync();
            var response = new ServiceResponse<List<TaskItem>>
            {
                Data = tasks
            };
            return response;
        }

        public async Task<ServiceResponse<TaskItem>> GetTaskItem(int taskItemId)
        {
            var response = new ServiceResponse<TaskItem>();
            var task = await _context.TaskItems.FindAsync(taskItemId);
            if (task == null)
            {
                response.Success = false;
                response.Message = "The task does not exist.";
            }
            else
            {
                response.Data = task;
            }

            return response;
        }

        public async Task<ServiceResponse<TaskItem>> PostTaskItem(TaskItem taskItem)
        {
            var response = new ServiceResponse<TaskItem>();
            //var findProject = await _context.Projects.FirstOrDefaultAsync(x => x.Id == taskItem.ProjectId);
            var findUser = await _context.Users.FirstOrDefaultAsync(x => x.Id == taskItem.AssignedToId);

            //if (findProject == null)
            //{
            //    response.Success = false;
            //    response.Message = "Provided project does not exist.";
            //}
            //else 
            
            if (findUser == null)
            {
                response.Success = false;
                response.Message = "Provided User does not exist.";
            }
            else
            {
                taskItem.DateCreated = DateTime.Now;
                response.Data = taskItem;
                _context.TaskItems.Add(taskItem);
                await _context.SaveChangesAsync();
            }

            return response;
        }

        public async Task<ServiceResponse<TaskItem>> UpdateTaskItem(TaskItem taskItem)
        {
            var findTask = await _context.TaskItems.FindAsync(taskItem.TaskItemId);
            if (findTask == null)
            {
                return new ServiceResponse<TaskItem>()
                {
                    Success = false,
                    Message = "TaskItem not found."
                };
            }

            findTask.Title = taskItem.Title;
            findTask.Description = taskItem.Description;
            findTask.AssignedToId = taskItem.AssignedToId;
            findTask.AuthorId = taskItem.AuthorId;
            findTask.EditorId = taskItem.EditorId;
            findTask.ProjectId = taskItem.ProjectId;
            findTask.DueDate = taskItem.DueDate;
            findTask.TaskStatus = taskItem.TaskStatus;
            findTask.Importance = taskItem.Importance;
            findTask.DateEdited = DateTime.Now;

            await _context.SaveChangesAsync();

            return new ServiceResponse<TaskItem> { Data = taskItem };
        }

        public async Task<ServiceResponse<TaskItem>> UpdateTaskItemStatusOnly(TaskItemToEditStatusDTO taskItemDto)
        {
            var findTask = await _context.TaskItems.FindAsync(taskItemDto.TaskItemId);
            if (findTask == null)
            {
                return new ServiceResponse<TaskItem>()
                {
                    Success = false,
                    Message = "TaskItem not found."
                };
            }

            findTask.DateEdited = DateTime.Now;

            var mappedTaskItem = _mapper.Map(taskItemDto, findTask);
            _context.Entry(findTask).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return new ServiceResponse<TaskItem> { Data = mappedTaskItem };

        }

        public async Task<ServiceResponse<bool>> DeleteTaskItem(int taskItemId)
        {
            var findTask = await _context.TaskItems.FindAsync(taskItemId);
            if (findTask == null)
            {
                return new ServiceResponse<bool>()
                {
                    Success = false,
                    Data = false,
                    Message = "Task not found."
                };
            }

            _context.TaskItems.Remove(findTask);
            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Data = true };
        }
    }
}