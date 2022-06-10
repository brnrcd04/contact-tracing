namespace contact_tracing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblContactTracingForm = new System.Windows.Forms.Label();
            this.lblAppDevName = new System.Windows.Forms.Label();
            this.lblFacemaskIcon = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtBoxFullName = new System.Windows.Forms.TextBox();
            this.lblFullNameGuide = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddressGuide = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxContactNo = new System.Windows.Forms.TextBox();
            this.lblSymptoms = new System.Windows.Forms.Label();
            this.txtBoxSymptoms = new System.Windows.Forms.TextBox();
            this.lblSymptomsGuide = new System.Windows.Forms.Label();
            this.lblVaccinatedGuide = new System.Windows.Forms.Label();
            this.lblVaccinated = new System.Windows.Forms.Label();
            this.txtBoxVaccinated = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSubmitButtonInfo = new System.Windows.Forms.Label();
            this.lblInfoIcon = new System.Windows.Forms.Label();
            this.txtBoxSex = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContactTracingForm
            // 
            this.lblContactTracingForm.AutoSize = true;
            this.lblContactTracingForm.Font = new System.Drawing.Font("SF Pro Display", 23F, System.Drawing.FontStyle.Bold);
            this.lblContactTracingForm.Location = new System.Drawing.Point(152, 30);
            this.lblContactTracingForm.Name = "lblContactTracingForm";
            this.lblContactTracingForm.Size = new System.Drawing.Size(473, 55);
            this.lblContactTracingForm.TabIndex = 0;
            this.lblContactTracingForm.Text = "Contact Tracing Form";
            // 
            // lblAppDevName
            // 
            this.lblAppDevName.AutoSize = true;
            this.lblAppDevName.Font = new System.Drawing.Font("SF Mono", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppDevName.Location = new System.Drawing.Point(159, 87);
            this.lblAppDevName.Name = "lblAppDevName";
            this.lblAppDevName.Size = new System.Drawing.Size(440, 33);
            this.lblAppDevName.TabIndex = 2;
            this.lblAppDevName.Text = "App by Bernard C. Narceda";
            this.lblAppDevName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAppDevName.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFacemaskIcon
            // 
            this.lblFacemaskIcon.AutoSize = true;
            this.lblFacemaskIcon.Font = new System.Drawing.Font("Font Awesome 5 Pro Regular", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacemaskIcon.Location = new System.Drawing.Point(12, 26);
            this.lblFacemaskIcon.Name = "lblFacemaskIcon";
            this.lblFacemaskIcon.Size = new System.Drawing.Size(139, 102);
            this.lblFacemaskIcon.TabIndex = 1;
            this.lblFacemaskIcon.Text = "";
            this.lblFacemaskIcon.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFullName.Location = new System.Drawing.Point(26, 157);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(96, 22);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAddress.Location = new System.Drawing.Point(26, 225);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(81, 22);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAge.Location = new System.Drawing.Point(483, 191);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(47, 22);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEmail.Location = new System.Drawing.Point(26, 340);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 22);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmailAddress_Click);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblContactNo.Location = new System.Drawing.Point(371, 340);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(110, 22);
            this.lblContactNo.TabIndex = 7;
            this.lblContactNo.Text = "Contact No.:";
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Location = new System.Drawing.Point(128, 155);
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.Size = new System.Drawing.Size(341, 26);
            this.txtBoxFullName.TabIndex = 8;
            // 
            // lblFullNameGuide
            // 
            this.lblFullNameGuide.AutoSize = true;
            this.lblFullNameGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameGuide.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblFullNameGuide.Location = new System.Drawing.Point(123, 189);
            this.lblFullNameGuide.Name = "lblFullNameGuide";
            this.lblFullNameGuide.Size = new System.Drawing.Size(346, 20);
            this.lblFullNameGuide.TabIndex = 9;
            this.lblFullNameGuide.Text = "Format: [First Name] [Middle Name] [Last Name]";
            this.lblFullNameGuide.Click += new System.EventHandler(this.lblNameGuide_Click);
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(535, 189);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(45, 26);
            this.txtBoxAge.TabIndex = 10;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(113, 223);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(497, 50);
            this.txtBoxAddress.TabIndex = 11;
            // 
            // lblAddressGuide
            // 
            this.lblAddressGuide.AutoSize = true;
            this.lblAddressGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressGuide.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblAddressGuide.Location = new System.Drawing.Point(108, 281);
            this.lblAddressGuide.Name = "lblAddressGuide";
            this.lblAddressGuide.Size = new System.Drawing.Size(488, 40);
            this.lblAddressGuide.TabIndex = 12;
            this.lblAddressGuide.Text = "Format: [Blk. No. Lot. No.], [Street], [Subdivision/Village], [Barangay], \r\n[Muni" +
    "cipality/City], [Province]";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(97, 338);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(257, 26);
            this.txtBoxEmail.TabIndex = 13;
            // 
            // txtBoxContactNo
            // 
            this.txtBoxContactNo.Location = new System.Drawing.Point(487, 338);
            this.txtBoxContactNo.Name = "txtBoxContactNo";
            this.txtBoxContactNo.Size = new System.Drawing.Size(123, 26);
            this.txtBoxContactNo.TabIndex = 14;
            // 
            // lblSymptoms
            // 
            this.lblSymptoms.AutoSize = true;
            this.lblSymptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSymptoms.Location = new System.Drawing.Point(26, 379);
            this.lblSymptoms.Name = "lblSymptoms";
            this.lblSymptoms.Size = new System.Drawing.Size(361, 22);
            this.lblSymptoms.TabIndex = 15;
            this.lblSymptoms.Text = "Are you experiencing COVID-19 symptoms?";
            // 
            // txtBoxSymptoms
            // 
            this.txtBoxSymptoms.Location = new System.Drawing.Point(30, 411);
            this.txtBoxSymptoms.Multiline = true;
            this.txtBoxSymptoms.Name = "txtBoxSymptoms";
            this.txtBoxSymptoms.Size = new System.Drawing.Size(580, 26);
            this.txtBoxSymptoms.TabIndex = 16;
            // 
            // lblSymptomsGuide
            // 
            this.lblSymptomsGuide.AutoSize = true;
            this.lblSymptomsGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymptomsGuide.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSymptomsGuide.Location = new System.Drawing.Point(25, 445);
            this.lblSymptomsGuide.Name = "lblSymptomsGuide";
            this.lblSymptomsGuide.Size = new System.Drawing.Size(549, 40);
            this.lblSymptomsGuide.TabIndex = 17;
            this.lblSymptomsGuide.Text = "If yes, type the symptoms in this format: Yes. [Symptom 1], [Symptom 2], etc. \r\nE" +
    "xample: Yes. Fever, cough, sore throat. If no, just type \"No\".";
            // 
            // lblVaccinatedGuide
            // 
            this.lblVaccinatedGuide.AutoSize = true;
            this.lblVaccinatedGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaccinatedGuide.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblVaccinatedGuide.Location = new System.Drawing.Point(27, 541);
            this.lblVaccinatedGuide.Name = "lblVaccinatedGuide";
            this.lblVaccinatedGuide.Size = new System.Drawing.Size(541, 80);
            this.lblVaccinatedGuide.TabIndex = 20;
            this.lblVaccinatedGuide.Text = "If yes, type: Yes, [1st dose/2nd dose/booster shot], [Vaccine Manufacturer], \r\nsi" +
    "nce [MM/DD/YYYY]. \r\nExample: Yes, 2nd dose, AstraZeneca, 01/30/2022.\r\nIf no, jus" +
    "t type \"No\".";
            // 
            // lblVaccinated
            // 
            this.lblVaccinated.AutoSize = true;
            this.lblVaccinated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblVaccinated.Location = new System.Drawing.Point(27, 505);
            this.lblVaccinated.Name = "lblVaccinated";
            this.lblVaccinated.Size = new System.Drawing.Size(222, 22);
            this.lblVaccinated.TabIndex = 18;
            this.lblVaccinated.Text = "Vaccinated for COVID-19?";
            // 
            // txtBoxVaccinated
            // 
            this.txtBoxVaccinated.Location = new System.Drawing.Point(255, 503);
            this.txtBoxVaccinated.Name = "txtBoxVaccinated";
            this.txtBoxVaccinated.Size = new System.Drawing.Size(355, 26);
            this.txtBoxVaccinated.TabIndex = 21;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(516, 640);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 43);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSubmitButtonInfo
            // 
            this.lblSubmitButtonInfo.AutoSize = true;
            this.lblSubmitButtonInfo.Location = new System.Drawing.Point(73, 641);
            this.lblSubmitButtonInfo.Name = "lblSubmitButtonInfo";
            this.lblSubmitButtonInfo.Size = new System.Drawing.Size(432, 40);
            this.lblSubmitButtonInfo.TabIndex = 23;
            this.lblSubmitButtonInfo.Text = "As you click the \"Submit\" button, a text file will be generated \r\nwhich contains " +
    "the data you submitted in this application.";
            // 
            // lblInfoIcon
            // 
            this.lblInfoIcon.AutoSize = true;
            this.lblInfoIcon.Font = new System.Drawing.Font("Font Awesome 5 Pro Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIcon.Location = new System.Drawing.Point(22, 643);
            this.lblInfoIcon.Name = "lblInfoIcon";
            this.lblInfoIcon.Size = new System.Drawing.Size(53, 38);
            this.lblInfoIcon.TabIndex = 24;
            this.lblInfoIcon.Text = "";
            // 
            // txtBoxSex
            // 
            this.txtBoxSex.Location = new System.Drawing.Point(535, 155);
            this.txtBoxSex.Name = "txtBoxSex";
            this.txtBoxSex.Size = new System.Drawing.Size(75, 26);
            this.txtBoxSex.TabIndex = 26;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSex.Location = new System.Drawing.Point(483, 157);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(46, 22);
            this.lblSex.TabIndex = 25;
            this.lblSex.Text = "Sex:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 710);
            this.Controls.Add(this.txtBoxSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblSubmitButtonInfo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxVaccinated);
            this.Controls.Add(this.lblVaccinatedGuide);
            this.Controls.Add(this.lblVaccinated);
            this.Controls.Add(this.lblSymptomsGuide);
            this.Controls.Add(this.txtBoxSymptoms);
            this.Controls.Add(this.lblSymptoms);
            this.Controls.Add(this.txtBoxContactNo);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblAddressGuide);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.lblFullNameGuide);
            this.Controls.Add(this.txtBoxFullName);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblAppDevName);
            this.Controls.Add(this.lblFacemaskIcon);
            this.Controls.Add(this.lblContactTracingForm);
            this.Controls.Add(this.lblInfoIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BCN\'s Contact Tracing Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContactTracingForm;
        private System.Windows.Forms.Label lblAppDevName;
        private System.Windows.Forms.Label lblFacemaskIcon;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtBoxFullName;
        private System.Windows.Forms.Label lblFullNameGuide;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label lblAddressGuide;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxContactNo;
        private System.Windows.Forms.Label lblSymptoms;
        private System.Windows.Forms.TextBox txtBoxSymptoms;
        private System.Windows.Forms.Label lblSymptomsGuide;
        private System.Windows.Forms.Label lblVaccinatedGuide;
        private System.Windows.Forms.Label lblVaccinated;
        private System.Windows.Forms.TextBox txtBoxVaccinated;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSubmitButtonInfo;
        private System.Windows.Forms.Label lblInfoIcon;
        private System.Windows.Forms.TextBox txtBoxSex;
        private System.Windows.Forms.Label lblSex;
    }
}

