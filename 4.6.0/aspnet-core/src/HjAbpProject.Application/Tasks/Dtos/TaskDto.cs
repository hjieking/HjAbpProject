﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HjAbpProject.Tasks.Dtos
{
    /// <summary>
    /// A DTO class that can be used in various application service methods when needed to send/receive Task objects.
    /// </summary>
    //[AutoMapFrom(typeof(Task))]
    public class TaskDto : EntityDto
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }

        //This method is just used by the Console Application to list tasks
        public override string ToString()
        {
            return string.Format(
                "[Task Id={0}, Description={1}, CreationTime={2}, State={3}]",
                Id,
                Description,
                CreationTime,
                (TaskState)State
                );
        }

        /// <summary>
        /// 根据任务状态，获取定义的css样式
        /// </summary>
        /// <returns></returns>
        public string GetTaskLable()
        {
            string style = "";
            TaskState state = (TaskState)Enum.Parse(typeof(TaskState), this.State.ToString());

            switch (state)
            {
                case TaskState.Open:
                    style = "fa-spinner fa-spin ";
                    break;
                case TaskState.Completed:
                    style = "fa-check-circle ";
                    break;
            }
            return style;

        }
    }
}
