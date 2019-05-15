using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using AutoMapper;
using HjAbpProject.Tasks.Dtos;

namespace HjAbpProject.Tasks
{
    public class TaskAppService : HjAbpProjectAppServiceBase, ITaskAppService
    {
        private readonly IRepository<Task> _taskRepository;
        public TaskAppService(IRepository<Task> taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public int CreateTask(CreateTaskInput input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            Logger.Info("Creating a task for input: " + input);
            

            var task = Mapper.Map<Task>(input);

            int result = _taskRepository.InsertAndGetId(task);
            
            return result;
        }

        public TaskDto GetTaskById(int taskId)
        {
            var task = _taskRepository.Get(taskId);

            var m= task.MapTo<TaskDto>();

            return task.MapTo<TaskDto>();
        }

        public void UpdateTask(UpdateTaskInput input)
        {
            //We can use Logger, it's defined in ApplicationService base class.
            Logger.Info("Updating a task for input: " + input);

            
            var updateTask = Mapper.Map<Task>(input);

            //再更新其他字段
            _taskRepository.Update(updateTask);
        }
    }
}
