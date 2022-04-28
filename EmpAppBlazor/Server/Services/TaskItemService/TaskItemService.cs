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

        public async Task<ServiceResponse<List<TaskItemGetDTO>>> GetTasks()
        {
            var tasks = await _context.TaskItems.Include(x => x.Project).Include(x => x.AssignedTo).Include(x => x.Author).Include(x => x.Editor).ToListAsync();
            var tasksDto = _mapper.Map<List<TaskItemGetDTO>>(tasks);

            var response = new ServiceResponse<List<TaskItemGetDTO>>
            {
                Data = tasksDto
            };
            return response;
        }

        public async Task<ServiceResponse<List<TaskItemGetDTO>>> GetTasksByUserId(int userId)
        {
            var tasks = await _context.TaskItems.Include(x => x.Project).Include(x => x.AssignedTo).Include(x => x.Author).Include(x => x.Editor).Where(x => x.AssignedToId == userId).ToListAsync();
            var tasksDto = _mapper.Map<List<TaskItemGetDTO>>(tasks);

            var response = new ServiceResponse<List<TaskItemGetDTO>>
            {
                Data = tasksDto
            };
            return response;
        }

        public async Task<ServiceResponse<TaskItemGetDTO>> GetSingleTaskItem(int taskItemId)
        {
            var response = new ServiceResponse<TaskItemGetDTO>();
            var task = await _context.TaskItems.Include(x => x.Project).Include(x => x.AssignedTo).Include(x => x.Author).Include(x => x.Editor).FirstOrDefaultAsync(x => x.TaskItemId == taskItemId);
            var tasktDto = _mapper.Map<TaskItemGetDTO>(task);

            if (task == null)
            {
                response.Success = false;
                response.Message = "The task does not exist.";
            }
            else
            {
                response.Data = tasktDto;
            }

            return response;
        }

        public async Task<ServiceResponse<bool>> CreateTaskItem(TaskItemAddDTO taskItem)
        {
            taskItem.DateCreated = DateTime.Now;
            _context.TaskItems.Add(_mapper.Map<TaskItem>(taskItem));
            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Message = "Task Created", Data = true };
        }

        public async Task<ServiceResponse<bool>> UpdateTaskItem(TaskItemUpdateDTO taskItem)
        {
            var findTask = await _context.TaskItems.FindAsync(taskItem.TaskItemId);
            if (findTask == null)
            {
                return new ServiceResponse<bool>()
                {
                    Success = false,
                    Message = "Task not found."
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

            return new ServiceResponse<bool> { Message = "Task Updated", Data = true };
        }

        public async Task<ServiceResponse<bool>> UpdateTaskItemStatusOnly(TaskItemToEditStatusDTO taskItemDto)
        {
            var findTask = await _context.TaskItems.FindAsync(taskItemDto.TaskItemId);
            if (findTask == null)
            {
                return new ServiceResponse<bool>()
                {
                    Success = false,
                    Message = "TaskItem not found."
                };
            }

            findTask.DateEdited = DateTime.Now;
            findTask.TaskStatus = taskItemDto.TaskStatus;
            findTask.EditorId = taskItemDto.EditorId;

            _context.Entry(findTask).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Message = "Task Status Updated", Data = true };
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

            return new ServiceResponse<bool> { Message = "Task Deleted", Data = true };
        }
    }
}