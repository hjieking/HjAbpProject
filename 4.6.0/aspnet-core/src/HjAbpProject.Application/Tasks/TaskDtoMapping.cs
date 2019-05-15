using AutoMapper;
using HjAbpProject.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HjAbpProject.Tasks
{
    public class TaskDtoMapping : IDtoMapping
    {
        public void CreateMapping(IMapperConfigurationExpression mapperConfig)
        {
            //定义单向映射
            mapperConfig.CreateMap<CreateTaskInput, Task>();
            mapperConfig.CreateMap<UpdateTaskInput, Task>();
            mapperConfig.CreateMap<TaskDto, UpdateTaskInput>();

            //自定义映射
            var taskDtoMapper = mapperConfig.CreateMap<Task, TaskDto>();
            taskDtoMapper.ForMember(dto => dto.Title, map => map.MapFrom(m => m.Title));
        }
    }
}
