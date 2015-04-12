namespace Calendar
{
    partial class EditAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label displayableDescriptionLabel;
            System.Windows.Forms.Label lengthLabel;
            System.Windows.Forms.Label startLabel;
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.AppointmentBinding = new System.Windows.Forms.BindingSource(this.components);
            this.displayableDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RepeatCheckbox = new System.Windows.Forms.CheckBox();
            this.RepeatPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RepeatEveryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RepeatCountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            displayableDescriptionLabel = new System.Windows.Forms.Label();
            lengthLabel = new System.Windows.Forms.Label();
            startLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentBinding)).BeginInit();
            this.RepeatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayableDescriptionLabel
            // 
            displayableDescriptionLabel.AutoSize = true;
            displayableDescriptionLabel.Location = new System.Drawing.Point(12, 9);
            displayableDescriptionLabel.Name = "displayableDescriptionLabel";
            displayableDescriptionLabel.Size = new System.Drawing.Size(120, 13);
            displayableDescriptionLabel.TabIndex = 3;
            displayableDescriptionLabel.Text = "Displayable Description:";
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new System.Drawing.Point(12, 35);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new System.Drawing.Size(43, 13);
            lengthLabel.TabIndex = 5;
            lengthLabel.Text = "Length:";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new System.Drawing.Point(12, 62);
            startLabel.Name = "startLabel";
            startLabel.Size = new System.Drawing.Size(32, 13);
            startLabel.TabIndex = 7;
            startLabel.Text = "Start:";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(345, 183);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(264, 183);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AppointmentBinding
            // 
            this.AppointmentBinding.DataSource = typeof(Calendar.IAppointment);
            // 
            // displayableDescriptionTextBox
            // 
            this.displayableDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayableDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AppointmentBinding, "DisplayableDescription", true));
            this.displayableDescriptionTextBox.Location = new System.Drawing.Point(143, 6);
            this.displayableDescriptionTextBox.Name = "displayableDescriptionTextBox";
            this.displayableDescriptionTextBox.Size = new System.Drawing.Size(277, 20);
            this.displayableDescriptionTextBox.TabIndex = 4;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AppointmentBinding, "Length", true));
            this.lengthTextBox.Location = new System.Drawing.Point(143, 32);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(277, 20);
            this.lengthTextBox.TabIndex = 6;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.startDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.AppointmentBinding, "Start", true));
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(143, 58);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(277, 20);
            this.startDateTimePicker.TabIndex = 8;
            // 
            // RepeatCheckbox
            // 
            this.RepeatCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatCheckbox.Location = new System.Drawing.Point(15, 89);
            this.RepeatCheckbox.Name = "RepeatCheckbox";
            this.RepeatCheckbox.Size = new System.Drawing.Size(405, 24);
            this.RepeatCheckbox.TabIndex = 9;
            this.RepeatCheckbox.Text = "Repeat";
            this.RepeatCheckbox.UseVisualStyleBackColor = true;
            this.RepeatCheckbox.CheckedChanged += new System.EventHandler(this.RepeatCheckbox_CheckedChanged);
            // 
            // RepeatPanel
            // 
            this.RepeatPanel.Controls.Add(this.label3);
            this.RepeatPanel.Controls.Add(this.RepeatCountTextBox);
            this.RepeatPanel.Controls.Add(this.label2);
            this.RepeatPanel.Controls.Add(this.RepeatEveryTextBox);
            this.RepeatPanel.Controls.Add(this.label1);
            this.RepeatPanel.Enabled = false;
            this.RepeatPanel.Location = new System.Drawing.Point(15, 112);
            this.RepeatPanel.Name = "RepeatPanel";
            this.RepeatPanel.Size = new System.Drawing.Size(405, 41);
            this.RepeatPanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "days, ";
            // 
            // RepeatEveryTextBox
            // 
            this.RepeatEveryTextBox.Location = new System.Drawing.Point(170, 8);
            this.RepeatEveryTextBox.Name = "RepeatEveryTextBox";
            this.RepeatEveryTextBox.Size = new System.Drawing.Size(65, 20);
            this.RepeatEveryTextBox.TabIndex = 1;
            this.RepeatEveryTextBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repeat this appointment every";
            // 
            // RepeatCountTextBox
            // 
            this.RepeatCountTextBox.Location = new System.Drawing.Point(282, 8);
            this.RepeatCountTextBox.Name = "RepeatCountTextBox";
            this.RepeatCountTextBox.Size = new System.Drawing.Size(65, 20);
            this.RepeatCountTextBox.TabIndex = 3;
            this.RepeatCountTextBox.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "times";
            // 
            // EditAppointmentForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 218);
            this.Controls.Add(this.RepeatPanel);
            this.Controls.Add(this.RepeatCheckbox);
            this.Controls.Add(displayableDescriptionLabel);
            this.Controls.Add(this.displayableDescriptionTextBox);
            this.Controls.Add(lengthLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(startLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "EditAppointmentForm";
            this.Text = "EditAppointmentForm";
            this.Load += new System.EventHandler(this.EditAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentBinding)).EndInit();
            this.RepeatPanel.ResumeLayout(false);
            this.RepeatPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.BindingSource AppointmentBinding;
        private System.Windows.Forms.TextBox displayableDescriptionTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.CheckBox RepeatCheckbox;
        private System.Windows.Forms.Panel RepeatPanel;
        private System.Windows.Forms.TextBox RepeatEveryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RepeatCountTextBox;
    }
}