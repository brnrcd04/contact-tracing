namespace contact_tracing
{
    partial class msgboxSubmit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msgboxSubmit));
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblCheckIcon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSuccess.Location = new System.Drawing.Point(22, 143);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(494, 225);
            this.lblSuccess.TabIndex = 0;
            this.lblSuccess.Text = resources.GetString("lblSuccess.Text");
            this.lblSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSuccess.Click += new System.EventHandler(this.lblSuccess_Click);
            // 
            // lblCheckIcon
            // 
            this.lblCheckIcon.AutoSize = true;
            this.lblCheckIcon.Font = new System.Drawing.Font("Font Awesome 5 Pro Regular", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIcon.Location = new System.Drawing.Point(226, 16);
            this.lblCheckIcon.Name = "lblCheckIcon";
            this.lblCheckIcon.Size = new System.Drawing.Size(139, 102);
            this.lblCheckIcon.TabIndex = 1;
            this.lblCheckIcon.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msgboxSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCheckIcon);
            this.Controls.Add(this.lblSuccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "msgboxSubmit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Success!";
            this.Load += new System.EventHandler(this.msgboxSubmit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblCheckIcon;
        private System.Windows.Forms.Button button1;
    }
}