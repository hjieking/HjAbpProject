using System;
using System.Collections.Generic;
using System.Text;

namespace HjAbpProject.Persons.Dtos
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
