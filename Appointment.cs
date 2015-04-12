using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Appointment : IAppointment
    {
        /// <summary>
        /// This Inherits from the IAppointment interface and uses the functions below to help structure an appointment so that it can be parsed out into a document of types.
        /// </summary>
        public DateTime Start { get; set; }

        public int Length { get; set; }

        public string DisplayableDescription { get; set; }

        public bool OccursOnDate(DateTime date)
        {
            return (Start.Date == date.Date);
        }


        public IAppointment Clone()
        {
            return new Appointment()
            {
                Start = this.Start,
                Length = this.Length,
                DisplayableDescription = this.DisplayableDescription
            };
        }
    }
}
