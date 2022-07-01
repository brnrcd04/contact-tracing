namespace contact_tracing
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.picBoxViewfinder = new System.Windows.Forms.PictureBox();
            this.txtBoxScanned = new System.Windows.Forms.TextBox();
            this.btnStartScanning = new System.Windows.Forms.Button();
            this.lblCamera = new System.Windows.Forms.Label();
            this.lblSubmitButtonInfo = new System.Windows.Forms.Label();
            this.lblInfoIcon = new System.Windows.Forms.Label();
            this.cboxCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxViewfinder)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxViewfinder
            // 
            this.picBoxViewfinder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picBoxViewfinder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxViewfinder.Location = new System.Drawing.Point(33, 67);
            this.picBoxViewfinder.Name = "picBoxViewfinder";
            this.picBoxViewfinder.Size = new System.Drawing.Size(350, 350);
            this.picBoxViewfinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxViewfinder.TabIndex = 0;
            this.picBoxViewfinder.TabStop = false;
            this.picBoxViewfinder.Click += new System.EventHandler(this.picBoxCamera_Click);
            // 
            // txtBoxScanned
            // 
            this.txtBoxScanned.Location = new System.Drawing.Point(429, 67);
            this.txtBoxScanned.Multiline = true;
            this.txtBoxScanned.Name = "txtBoxScanned";
            this.txtBoxScanned.Size = new System.Drawing.Size(330, 307);
            this.txtBoxScanned.TabIndex = 2;
            this.txtBoxScanned.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnStartScanning
            // 
            this.btnStartScanning.Location = new System.Drawing.Point(528, 401);
            this.btnStartScanning.Name = "btnStartScanning";
            this.btnStartScanning.Size = new System.Drawing.Size(133, 43);
            this.btnStartScanning.TabIndex = 3;
            this.btnStartScanning.Text = "Start Scanning";
            this.btnStartScanning.UseVisualStyleBackColor = true;
            this.btnStartScanning.Click += new System.EventHandler(this.btnStartScanning_Click);
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera.Location = new System.Drawing.Point(29, 29);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(78, 22);
            this.lblCamera.TabIndex = 4;
            this.lblCamera.Text = "Camera:";
            // 
            // lblSubmitButtonInfo
            // 
            this.lblSubmitButtonInfo.AutoSize = true;
            this.lblSubmitButtonInfo.Location = new System.Drawing.Point(74, 465);
            this.lblSubmitButtonInfo.Name = "lblSubmitButtonInfo";
            this.lblSubmitButtonInfo.Size = new System.Drawing.Size(691, 60);
            this.lblSubmitButtonInfo.TabIndex = 25;
            this.lblSubmitButtonInfo.Text = resources.GetString("lblSubmitButtonInfo.Text");
            // 
            // lblInfoIcon
            // 
            this.lblInfoIcon.AutoSize = true;
            this.lblInfoIcon.Font = new System.Drawing.Font("Font Awesome 5 Pro Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIcon.Location = new System.Drawing.Point(23, 467);
            this.lblInfoIcon.Name = "lblInfoIcon";
            this.lblInfoIcon.Size = new System.Drawing.Size(53, 38);
            this.lblInfoIcon.TabIndex = 26;
            this.lblInfoIcon.Text = "";
            // 
            // cboxCamera
            // 
            this.cboxCamera.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboxCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCamera.FormattingEnabled = true;
            this.cboxCamera.Location = new System.Drawing.Point(114, 29);
            this.cboxCamera.Name = "cboxCamera";
            this.cboxCamera.Size = new System.Drawing.Size(270, 28);
            this.cboxCamera.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Viewfinder";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Data obtained from scanned QR Code";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxCamera);
            this.Controls.Add(this.lblSubmitButtonInfo);
            this.Controls.Add(this.lblInfoIcon);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.btnStartScanning);
            this.Controls.Add(this.txtBoxScanned);
            this.Controls.Add(this.picBoxViewfinder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxViewfinder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxViewfinder;
        private System.Windows.Forms.TextBox txtBoxScanned;
        private System.Windows.Forms.Button btnStartScanning;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Label lblSubmitButtonInfo;
        private System.Windows.Forms.Label lblInfoIcon;
        private System.Windows.Forms.ComboBox cboxCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}