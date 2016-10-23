using CloseOut.Data.Abstract;
using CloseOut.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloseOut.Data.Repositories
{
    public class ScheduleRepository : EntityBaseRepository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(SchedulerContext context)
            : base(context)
        { }
    }
}
