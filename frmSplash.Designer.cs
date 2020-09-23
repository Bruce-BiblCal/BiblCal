
namespace BiblCal
{
	partial class frmSplash
	{

		#region "Upgrade Support "
		private static frmSplash m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmSplash DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
				{
					m_InitializingDefInstance = true;
					m_vb6FormDefInstance = CreateInstance();
					m_InitializingDefInstance = false;
				}
				return m_vb6FormDefInstance;
			}
			set
			{
				m_vb6FormDefInstance = value;
			}
		}

		#endregion
		#region "Windows Form Designer generated code "
		public static frmSplash CreateInstance()
		{
			frmSplash theInstance = new frmSplash();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "tmrPicRot", "timDelay", "imgLogo", "lblCopyright", "lblCompany", "lblWarning", "lblVersion", "lblPlatform", "lblProductName", "lblLicenseTo", "lblCompanyProduct", "Frame1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Timer tmrPicRot;
		public System.Windows.Forms.Timer timDelay;
		public System.Windows.Forms.PictureBox imgLogo;
		public System.Windows.Forms.Label lblCopyright;
		public System.Windows.Forms.Label lblCompany;
		public System.Windows.Forms.Label lblWarning;
		public System.Windows.Forms.Label lblVersion;
		public System.Windows.Forms.Label lblPlatform;
		public System.Windows.Forms.Label lblProductName;
		public System.Windows.Forms.Label lblLicenseTo;
		public System.Windows.Forms.Label lblCompanyProduct;
		public System.Windows.Forms.GroupBox Frame1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.tmrPicRot = new System.Windows.Forms.Timer(components);
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.timDelay = new System.Windows.Forms.Timer(components);
			this.imgLogo = new System.Windows.Forms.PictureBox();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.lblCompany = new System.Windows.Forms.Label();
			this.lblWarning = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblPlatform = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblLicenseTo = new System.Windows.Forms.Label();
			this.lblCompanyProduct = new System.Windows.Forms.Label();
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tmrPicRot
			// 
			this.tmrPicRot.Enabled = true;
			this.tmrPicRot.Interval = 63;
			this.tmrPicRot.Tick += new System.EventHandler(this.tmrPicRot_Tick);
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.Color.Aqua;
			this.Frame1.Controls.Add(this.imgLogo);
			this.Frame1.Controls.Add(this.lblCopyright);
			this.Frame1.Controls.Add(this.lblCompany);
			this.Frame1.Controls.Add(this.lblWarning);
			this.Frame1.Controls.Add(this.lblVersion);
			this.Frame1.Controls.Add(this.lblPlatform);
			this.Frame1.Controls.Add(this.lblProductName);
			this.Frame1.Controls.Add(this.lblLicenseTo);
			this.Frame1.Controls.Add(this.lblCompanyProduct);
			this.Frame1.Enabled = true;
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(8, 8);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(472, 270);
			this.Frame1.TabIndex = 0;
			this.Frame1.Visible = true;
			this.Frame1.Click += new System.EventHandler(this.Frame1_Click);
			// 
			// timDelay
			// 
			this.timDelay.Enabled = true;
			this.timDelay.Interval = 5340;
			this.timDelay.Tick += new System.EventHandler(this.timDelay_Tick);
			// 
			// imgLogo
			// 
			this.imgLogo.AllowDrop = true;
			this.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.imgLogo.Enabled = true;
			this.imgLogo.Image = (System.Drawing.Image) resources.GetObject("imgLogo.Image");
			this.imgLogo.Location = new System.Drawing.Point(24, 64);
			this.imgLogo.Name = "imgLogo";
			this.imgLogo.Size = new System.Drawing.Size(121, 135);
			this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgLogo.Visible = true;
			// 
			// lblCopyright
			// 
			this.lblCopyright.AllowDrop = true;
			this.lblCopyright.BackColor = System.Drawing.Color.Aqua;
			this.lblCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCopyright.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCopyright.Location = new System.Drawing.Point(264, 200);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCopyright.Size = new System.Drawing.Size(161, 17);
			this.lblCopyright.TabIndex = 4;
			this.lblCopyright.Text = "Copyright 1986 - 2016";
			// 
			// lblCompany
			// 
			this.lblCompany.AllowDrop = true;
			this.lblCompany.BackColor = System.Drawing.Color.Aqua;
			this.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCompany.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCompany.Location = new System.Drawing.Point(264, 218);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCompany.Size = new System.Drawing.Size(201, 17);
			this.lblCompany.TabIndex = 3;
			this.lblCompany.Text = "Central Highlands Christian Publications";
			// 
			// lblWarning
			// 
			this.lblWarning.AllowDrop = true;
			this.lblWarning.BackColor = System.Drawing.Color.Aqua;
			this.lblWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblWarning.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblWarning.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblWarning.Location = new System.Drawing.Point(10, 244);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblWarning.Size = new System.Drawing.Size(457, 13);
			this.lblWarning.TabIndex = 2;
			this.lblWarning.Text = "Warning";
			this.lblWarning.Visible = false;
			// 
			// lblVersion
			// 
			this.lblVersion.AllowDrop = true;
			this.lblVersion.AutoSize = true;
			this.lblVersion.BackColor = System.Drawing.Color.Aqua;
			this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblVersion.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblVersion.Location = new System.Drawing.Point(392, 180);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblVersion.Size = new System.Drawing.Size(59, 19);
			this.lblVersion.TabIndex = 5;
			this.lblVersion.Text = "Version";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblPlatform
			// 
			this.lblPlatform.AllowDrop = true;
			this.lblPlatform.AutoSize = true;
			this.lblPlatform.BackColor = System.Drawing.Color.Aqua;
			this.lblPlatform.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPlatform.Font = new System.Drawing.Font("Arial", 15.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblPlatform.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPlatform.Location = new System.Drawing.Point(344, 156);
			this.lblPlatform.Name = "lblPlatform";
			this.lblPlatform.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPlatform.Size = new System.Drawing.Size(92, 24);
			this.lblPlatform.TabIndex = 6;
			this.lblPlatform.Text = "Windows";
			this.lblPlatform.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblProductName
			// 
			this.lblProductName.AllowDrop = true;
			this.lblProductName.AutoSize = true;
			this.lblProductName.BackColor = System.Drawing.Color.Aqua;
			this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblProductName.Font = new System.Drawing.Font("Arial", 26.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblProductName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProductName.Location = new System.Drawing.Point(168, 76);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProductName.Size = new System.Drawing.Size(275, 41);
			this.lblProductName.TabIndex = 8;
			this.lblProductName.Text = "Biblical Calendar";
			// 
			// lblLicenseTo
			// 
			this.lblLicenseTo.AllowDrop = true;
			this.lblLicenseTo.BackColor = System.Drawing.Color.Aqua;
			this.lblLicenseTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblLicenseTo.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblLicenseTo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLicenseTo.Location = new System.Drawing.Point(8, 16);
			this.lblLicenseTo.Name = "lblLicenseTo";
			this.lblLicenseTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLicenseTo.Size = new System.Drawing.Size(457, 17);
			this.lblLicenseTo.TabIndex = 1;
			this.lblLicenseTo.Text = "LicenseTo All Who Seak Truth";
			this.lblLicenseTo.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblLicenseTo.Visible = false;
			// 
			// lblCompanyProduct
			// 
			this.lblCompanyProduct.AllowDrop = true;
			this.lblCompanyProduct.AutoSize = true;
			this.lblCompanyProduct.BackColor = System.Drawing.Color.Aqua;
			this.lblCompanyProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCompanyProduct.Font = new System.Drawing.Font("Arial", 18f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblCompanyProduct.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCompanyProduct.Location = new System.Drawing.Point(168, 47);
			this.lblCompanyProduct.Name = "lblCompanyProduct";
			this.lblCompanyProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCompanyProduct.Size = new System.Drawing.Size(202, 29);
			this.lblCompanyProduct.TabIndex = 7;
			this.lblCompanyProduct.Text = "CHC Publications";
			// 
			// frmSplash
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
			this.ClientSize = new System.Drawing.Size(489, 286);
			this.ControlBox = false;
			this.Controls.Add(this.Frame1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.Location = new System.Drawing.Point(274, 180);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSplash";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Activated += new System.EventHandler(this.frmSplash_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_KeyPress);
			this.Frame1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		#endregion
	}
}