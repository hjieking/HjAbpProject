using Abp.Application.Services;
using HjAbpProject.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HjAbpProject.Tasks
{
    public interface ITaskAppService:IApplicationService
    {


        void UpdateTask(UpdateTaskInput input);

        int CreateTask(CreateTaskInput input);

        TaskDto GetTaskById(int taskId);
    }
}
