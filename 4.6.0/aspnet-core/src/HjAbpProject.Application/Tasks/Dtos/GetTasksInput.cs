using HjAbpProject.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HjAbpProject.Tasks.Dtos
{
    public class GetTasksInput: PagedSortedAndFilteredInputDto
    {
        public TaskState? State { get; set; }
    }
}
