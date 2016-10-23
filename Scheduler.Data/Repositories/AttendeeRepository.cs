using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloseOut.Model;
using CloseOut.Data;
using CloseOut.Data.Repositories;
using CloseOut.Data.Abstract;

namespace CloseOut.Data.Repositories
{
    public class AttendeeRepository : EntityBaseRepository<Attendee>, IAttendeeRepository
    {
        public AttendeeRepository(SchedulerContext context)
            : base(context)
        { }
    }
}
