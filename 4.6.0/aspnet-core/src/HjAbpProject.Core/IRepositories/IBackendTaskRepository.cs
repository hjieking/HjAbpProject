using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HjAbpProject.IRepositories
{
    public  interface IBackendTaskRepository:IRepository<Tasks.Task>
    {
    }
}
