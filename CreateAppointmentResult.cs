using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class EditAppointmentResult
    {
        public Boolean IsSuccess { get; set; }

        public Boolean ShouldRepeat { get; set; }
        public Int32 RepeatFrequency { get; set; }
        public Int32 TotalRepitions { get; set; }


        public static EditAppointmentResult Success()
        {
            return new EditAppointmentResult()
            {
                IsSuccess = true,
                ShouldRepeat = false
            };
        }

        public static EditAppointmentResult Success(Int32 repeatFrequency, Int32 totalRepetitions)
        {
            return new EditAppointmentResult()
            {
                IsSuccess = true,
                ShouldRepeat = true,
                RepeatFrequency = repeatFrequency,
                TotalRepitions = totalRepetitions
            };
        }

        public static EditAppointmentResult Fail()
        {
            return new EditAppointmentResult()
            {
                IsSuccess = false
            };
        }



    }
}
