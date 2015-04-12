using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public static class UIService
    {


        public static void CreateAppointment(Boolean isRecurring)
        {
            // Create a new Appointment object
            var appt = new Appointment()
            {
                Start = DateTime.Now.Date.AddHours(DateTime.Now.TimeOfDay.TotalHours),
                Length = 30,
                DisplayableDescription = "New Appointment"
            };

            // Edit it
            var editResult = EditAppointmentCore(appt, isRecurring);
            if (!editResult.IsSuccess)
                return;

            // Save it by inserting into storage
            CalendarApplication.MainForm._Appointments.Add(appt);

            // Add any recurring appointments, too?
            if (editResult.ShouldRepeat)
            {
                var repeatAppt = appt.Clone();

                for (int r = 0; r < editResult.TotalRepitions; r++)
                {
                    repeatAppt.Start += TimeSpan.FromDays(editResult.RepeatFrequency);
                    CalendarApplication.MainForm._Appointments.Add(repeatAppt);
                    repeatAppt = repeatAppt.Clone();
                }
            }


            CalendarApplication.MainForm._Appointments.Save();
            CalendarApplication.MainForm.RefreshAppointments();
            return;
        }


        public static void EditAppointment(IAppointment appt)
        {
            // Edit the existing appointment
            var res = EditAppointmentCore(appt, false);
            if (!res.IsSuccess)
                return;

            // save it
            CalendarApplication.MainForm._Appointments.Save();
            CalendarApplication.MainForm.RefreshAppointments();
        }

        /// <summary>
        /// Just edit the appt, don't save!
        /// </summary>
        /// <param name="appt"></param>
        private static EditAppointmentResult EditAppointmentCore(IAppointment appt, Boolean isRecurring)
        {
            // Clone the appointment into a working copy
            var workingCopy = appt.Clone();

            var isValid = true;

            do
            {
                isValid = true;

                // Show UI
                using (var editForm = new EditAppointmentForm(workingCopy))
                {
                    editForm.ShouldRepeat = isRecurring;

                    if (editForm.ShowDialog() != DialogResult.OK)
                        return EditAppointmentResult.Fail();


                    // Validation
                    if (appt.Length < 30)
                    {
                        // Invalid length - must be at least 30
                        MessageBox.Show("Length must be at least 30 minutes");
                        isValid = false;
                    }

                    if (appt.Length % 30 != 0)
                    {
                        // Invalid length - must be a multiple of 30
                        MessageBox.Show("Length must be a multiple of 30 minutes");
                        isValid = false;
                    }

                    if (String.IsNullOrEmpty(appt.DisplayableDescription))
                    {
                        // Must add a description
                        MessageBox.Show("An appointment without a description is BLOODY USELESS");
                        isValid = false;
                    }

                    // TODO: Also validate the Repeat Frequency and TotalRepitions values

                    if (isValid)
                    {
                        // if ok, write back to the original object
                        appt.DisplayableDescription = workingCopy.DisplayableDescription;
                        appt.Length = workingCopy.Length;
                        appt.Start = workingCopy.Start;

                        if (editForm.ShouldRepeat)
                        {
                            return EditAppointmentResult.Success(editForm.RepeatEvery, editForm.TotalRepitions);
                        }
                        else
                        {
                            return EditAppointmentResult.Success();
                        }
                    }
                }

            } while (isValid);

            return EditAppointmentResult.Fail();
        }


    }
}
