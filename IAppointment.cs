using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public interface IAppointment
    {
        DateTime Start { get; set; }

        int Length { get; set; }

        string DisplayableDescription { get; set; }

        bool OccursOnDate(DateTime date);

        IAppointment Clone();
    }
}
