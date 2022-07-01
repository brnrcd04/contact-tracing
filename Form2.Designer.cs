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
            this.lblStartScanningInfo = new System.Windows.Forms.Label();
            this.lblInfoIcon3 = new System.Windows.Forms.Label();
            this.cboxCamera = new System.Windows.Forms.ComboBox();
            this.lblViewfinder = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScanned = new System.Windows.Forms.Label();
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
            // lblStartScanningInfo
            // 
            this.lblStartScanningInfo.AutoSize = true;
            this.lblStartScanningInfo.Location = new System.Drawing.Point(74, 465);
            this.lblStartScanningInfo.Name = "lblStartScanningInfo";
            this.lblStartScanningInfo.Size = new System.Drawing.Size(684, 60);
            this.lblStartScanningInfo.TabIndex = 25;
            this.lblStartScanningInfo.Text = resources.GetString("lblStartScanningInfo.Text");
            // 
            // lblInfoIcon3
            // 
            this.lblInfoIcon3.AutoSize = true;
            this.lblInfoIcon3.Font = new System.Drawing.Font("Font Awesome 5 Pro Regular", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIcon3.Location = new System.Drawing.Point(23, 467);
            this.lblInfoIcon3.Name = "lblInfoIcon3";
            this.lblInfoIcon3.Size = new System.Drawing.Size(53, 38);
            this.lblInfoIcon3.TabIndex = 26;
            this.lblInfoIcon3.Text = "";
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
            // lblViewfinder
            // 
            this.lblViewfinder.AutoSize = true;
            this.lblViewfinder.Location = new System.Drawing.Point(167, 424);
            this.lblViewfinder.Name = "lblViewfinder";
            this.lblViewfinder.Size = new System.Drawing.Size(83, 20);
            this.lblViewfinder.TabIndex = 28;
            this.lblViewfinder.Text = "Viewfinder";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScanned
            // 
            this.lblScanned.AutoSize = true;
            this.lblScanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanned.Location = new System.Drawing.Point(437, 29);
            this.lblScanned.Name = "lblScanned";
            this.lblScanned.Size = new System.Drawing.Size(315, 22);
            this.lblScanned.TabIndex = 29;
            this.lblScanned.Text = "Data obtained from scanned QR Code";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 549);
            this.Controls.Add(this.lblScanned);
            this.Controls.Add(this.lblViewfinder);
            this.Controls.Add(this.cboxCamera);
            this.Controls.Add(this.lblStartScanningInfo);
            this.Controls.Add(this.lblInfoIcon3);
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
        private System.Windows.Forms.Label lblStartScanningInfo;
        private System.Windows.Forms.Label lblInfoIcon3;
        private System.Windows.Forms.ComboBox cboxCamera;
        private System.Windows.Forms.Label lblViewfinder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScanned;
    }
}