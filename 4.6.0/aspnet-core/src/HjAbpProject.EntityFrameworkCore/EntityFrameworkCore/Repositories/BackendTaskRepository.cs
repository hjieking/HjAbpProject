using Abp.EntityFrameworkCore;
using HjAbpProject.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HjAbpProject.EntityFrameworkCore.Repositories
{
    public class BackendTaskRepository: HjAbpProjectRepositoryBase<Tasks.Task>, IBackendTaskRepository
    {
        public BackendTaskRepository(IDbContextProvider<HjAbpProjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
