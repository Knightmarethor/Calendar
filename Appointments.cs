using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace Calendar
{
    public class Appointments : List<IAppointment>, IAppointments
    {
       
        // This inherits from a list of classes from IAppointment interface but also IAppointments.
        // The _filePath string is private static and readonly so that it not only cannot be changed but cannot be called outside of this class.
     
        private static readonly string _filePath = "Appointment.csv";
        //This method is used to Load a file from memory in which to load appointments from.
        
        public bool Load()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    Debug.WriteLine("File Not Found");
                    return false;
                }
                //This reads all the lines of the file into memory
                var theFile = File.ReadAllLines(_filePath);
                //Then clears the list
                Clear();
                //This For loop looks for commas to then split the line into it's different pieces then they are converted into their respective formats.
                foreach (var line in theFile)
                {
                    var lineParts = line.Split(',');

                    var newAppt = new Appointment();
                    newAppt.Start = Convert.ToDateTime(lineParts[0]);
                    newAppt.Length = Convert.ToInt32(lineParts[1]);
                    newAppt.DisplayableDescription = lineParts[2];

                    this.Add(newAppt);
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        //This method is going to save your document/Appointments.
        public bool Save()
        {
            try
            {
                //using a string builder it allows easy concatenation of strings since the file is comma seperated it's easier to use this method. 
                StringBuilder fileContents = new StringBuilder();
                
                foreach (IAppointment appt in this)
	            {
                    fileContents.AppendLine(appt.Start.ToString("yyyy-MM-dd HH:mm") + "," + appt.Length.ToString() + "," + appt.DisplayableDescription);
	            }

                File.WriteAllText(_filePath, fileContents.ToString());
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        //This checks a date and returns any appointments that are on the date.
        public IEnumerable<IAppointment> GetAppointmentsOnDate(DateTime date)
        {
            var day = date.Date;

            foreach (IAppointment appt in this)
            {
                if (appt.Start.Date == day)
                    yield return appt;
            }
        }
    }
}
