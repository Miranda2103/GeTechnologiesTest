namespace Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMonitorFilesLocation = new TextBox();
            lblMonitorFilesLocation = new Label();
            groupBox1 = new GroupBox();
            btnAceptar = new Button();
            lblVersion = new Label();
            txtVersion = new TextBox();
            lblInstallationFolder = new Label();
            txtInstallationFolder = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMonitorFilesLocation
            // 
            txtMonitorFilesLocation.Location = new Point(155, 16);
            txtMonitorFilesLocation.Name = "txtMonitorFilesLocation";
            txtMonitorFilesLocation.Size = new Size(250, 23);
            txtMonitorFilesLocation.TabIndex = 0;
            txtMonitorFilesLocation.Text = "C:\\GeTechnologies\\MonitorFiles";
            // 
            // lblMonitorFilesLocation
            // 
            lblMonitorFilesLocation.AutoSize = true;
            lblMonitorFilesLocation.Location = new Point(6, 19);
            lblMonitorFilesLocation.Name = "lblMonitorFilesLocation";
            lblMonitorFilesLocation.Size = new Size(128, 15);
            lblMonitorFilesLocation.TabIndex = 1;
            lblMonitorFilesLocation.Text = "Monitor Files Location:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(lblVersion);
            groupBox1.Controls.Add(txtVersion);
            groupBox1.Controls.Add(lblInstallationFolder);
            groupBox1.Controls.Add(txtInstallationFolder);
            groupBox1.Controls.Add(lblMonitorFilesLocation);
            groupBox1.Controls.Add(txtMonitorFilesLocation);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(330, 103);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(6, 77);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(48, 15);
            lblVersion.TabIndex = 5;
            lblVersion.Text = "Version:";
            // 
            // txtVersion
            // 
            txtVersion.Location = new Point(155, 74);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(250, 23);
            txtVersion.TabIndex = 4;
            txtVersion.Text = "1";
            // 
            // lblInstallationFolder
            // 
            lblInstallationFolder.AutoSize = true;
            lblInstallationFolder.Location = new Point(6, 48);
            lblInstallationFolder.Name = "lblInstallationFolder";
            lblInstallationFolder.Size = new Size(104, 15);
            lblInstallationFolder.TabIndex = 3;
            lblInstallationFolder.Text = "Installation Folder:";
            // 
            // txtInstallationFolder
            // 
            txtInstallationFolder.Location = new Point(155, 45);
            txtInstallationFolder.Name = "txtInstallationFolder";
            txtInstallationFolder.Size = new Size(250, 23);
            txtInstallationFolder.TabIndex = 2;
            txtInstallationFolder.Text = "C:\\GeTechnologies\\InstallationFolder";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMonitorFilesLocation;
        private Label lblMonitorFilesLocation;
        private GroupBox groupBox1;
        private Label lblVersion;
        private TextBox txtVersion;
        private Label lblInstallationFolder;
        private TextBox txtInstallationFolder;
        private Button btnAceptar;
    }
}