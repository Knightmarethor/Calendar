using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class EditAppointmentForm : Form
    {

        public IAppointment Appointment { get; set; }
        
        public Boolean ShouldRepeat
        {
            get
            {
                return RepeatCheckbox.Checked;
            }
            set
            {
                RepeatCheckbox.Checked = value;
            }
        }

        public Int32 RepeatEvery
        {
            get
            {
                return Convert.ToInt32(RepeatEveryTextBox.Text);
            }
            set
            {
                RepeatEveryTextBox.Text = value.ToString();
            }
        }

        public Int32 TotalRepitions
        {
            get
            {
                return Convert.ToInt32(RepeatCountTextBox.Text);
            }
            set
            {
                RepeatCountTextBox.Text = value.ToString();
            }
        }


        public EditAppointmentForm(IAppointment appt)
        {
            InitializeComponent();
            Appointment = appt;
            AppointmentBinding.DataSource = appt;


        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            
            // TODO: Add validation for repeat frequency.
            
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void EditAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void RepeatCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            RepeatPanel.Enabled = RepeatCheckbox.Checked;
        }
    }
}
