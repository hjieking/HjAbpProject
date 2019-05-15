using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HjAbpProject.Tasks.Dtos
{
    public class CreateTaskInput
    {

        [Required]
        public string Description { get; set; }

        [Required]
        public string Title { get; set; }

        public TaskState State { get; set; }
        public override string ToString()
        {
            return string.Format("[CreateTaskInput >  , Description = {0}]", Description);
        }
    }
}
