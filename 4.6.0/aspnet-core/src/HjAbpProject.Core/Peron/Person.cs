using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HjAbpProject.Peron
{
    /// <summary>
    /// long表示主键类型可以改变
    /// </summary>
    public class Person:Entity<int>
    {
        public virtual string Name { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public Person()
        {
            CreationTime = DateTime.Now;
        }
    }
}
