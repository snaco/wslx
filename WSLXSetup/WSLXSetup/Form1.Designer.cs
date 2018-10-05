namespace WSLXSetup
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.xserver_client = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.xsrvc_label = new System.Windows.Forms.Label();
			this.wsl_distro = new System.Windows.Forms.ComboBox();
			this.window_manager = new System.Windows.Forms.ComboBox();
			this.distro_label = new System.Windows.Forms.Label();
			this.windowmgr_label = new System.Windows.Forms.Label();
			this.get_dep_btn = new System.Windows.Forms.Button();
			this.get_dep_tip = new System.Windows.Forms.ToolTip(this.components);
			this.exec_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// xserver_client
			// 
			this.xserver_client.BackColor = System.Drawing.SystemColors.Window;
			this.xserver_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.xserver_client.FormattingEnabled = true;
			this.xserver_client.Items.AddRange(new object[] {
            "X410",
            "VcXsrv"});
			this.xserver_client.Location = new System.Drawing.Point(12, 24);
			this.xserver_client.Name = "xserver_client";
			this.xserver_client.Size = new System.Drawing.Size(153, 24);
			this.xserver_client.TabIndex = 0;
			this.xserver_client.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Turquoise;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(138, 97);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 51);
			this.button1.TabIndex = 1;
			this.button1.Text = "Generate Config";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// xsrvc_label
			// 
			this.xsrvc_label.AutoSize = true;
			this.xsrvc_label.Location = new System.Drawing.Point(12, 4);
			this.xsrvc_label.Name = "xsrvc_label";
			this.xsrvc_label.Size = new System.Drawing.Size(98, 17);
			this.xsrvc_label.TabIndex = 2;
			this.xsrvc_label.Text = "XServer Client";
			// 
			// wsl_distro
			// 
			this.wsl_distro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.wsl_distro.FormattingEnabled = true;
			this.wsl_distro.Items.AddRange(new object[] {
            "Ubuntu 18.04",
            "Debian GNU/Linux",
            "openSUSE Leap 42",
            "Kali"});
			this.wsl_distro.Location = new System.Drawing.Point(170, 24);
			this.wsl_distro.Name = "wsl_distro";
			this.wsl_distro.Size = new System.Drawing.Size(182, 24);
			this.wsl_distro.TabIndex = 3;
			// 
			// window_manager
			// 
			this.window_manager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.window_manager.FormattingEnabled = true;
			this.window_manager.Items.AddRange(new object[] {
            "i3"});
			this.window_manager.Location = new System.Drawing.Point(358, 24);
			this.window_manager.Name = "window_manager";
			this.window_manager.Size = new System.Drawing.Size(121, 24);
			this.window_manager.TabIndex = 4;
			// 
			// distro_label
			// 
			this.distro_label.AutoSize = true;
			this.distro_label.Location = new System.Drawing.Point(167, 4);
			this.distro_label.Name = "distro_label";
			this.distro_label.Size = new System.Drawing.Size(79, 17);
			this.distro_label.TabIndex = 5;
			this.distro_label.Text = "WSL Distro";
			// 
			// windowmgr_label
			// 
			this.windowmgr_label.AutoSize = true;
			this.windowmgr_label.Location = new System.Drawing.Point(355, 4);
			this.windowmgr_label.Name = "windowmgr_label";
			this.windowmgr_label.Size = new System.Drawing.Size(117, 17);
			this.windowmgr_label.TabIndex = 6;
			this.windowmgr_label.Text = "Window Manager";
			// 
			// get_dep_btn
			// 
			this.get_dep_btn.BackColor = System.Drawing.Color.SpringGreen;
			this.get_dep_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.get_dep_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.get_dep_btn.Location = new System.Drawing.Point(12, 97);
			this.get_dep_btn.Name = "get_dep_btn";
			this.get_dep_btn.Size = new System.Drawing.Size(121, 51);
			this.get_dep_btn.TabIndex = 7;
			this.get_dep_btn.Text = "Install WM";
			this.get_dep_btn.UseVisualStyleBackColor = false;
			this.get_dep_btn.Click += new System.EventHandler(this.get_dep_btn_Click);
			// 
			// get_dep_tip
			// 
			this.get_dep_tip.ShowAlways = true;
			this.get_dep_tip.ToolTipTitle = "Hello";
			// 
			// exec_btn
			// 
			this.exec_btn.BackColor = System.Drawing.Color.Firebrick;
			this.exec_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exec_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.exec_btn.Location = new System.Drawing.Point(297, 97);
			this.exec_btn.Name = "exec_btn";
			this.exec_btn.Size = new System.Drawing.Size(182, 51);
			this.exec_btn.TabIndex = 8;
			this.exec_btn.Text = "Exit and Run WSLX";
			this.exec_btn.UseVisualStyleBackColor = false;
			this.exec_btn.Click += new System.EventHandler(this.exec_btn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowText;
			this.ClientSize = new System.Drawing.Size(489, 160);
			this.Controls.Add(this.exec_btn);
			this.Controls.Add(this.get_dep_btn);
			this.Controls.Add(this.windowmgr_label);
			this.Controls.Add(this.distro_label);
			this.Controls.Add(this.window_manager);
			this.Controls.Add(this.wsl_distro);
			this.Controls.Add(this.xsrvc_label);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.xserver_client);
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "WSLX Setup";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox xserver_client;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label xsrvc_label;
		private System.Windows.Forms.ComboBox wsl_distro;
		private System.Windows.Forms.ComboBox window_manager;
		private System.Windows.Forms.Label distro_label;
		private System.Windows.Forms.Label windowmgr_label;
		private System.Windows.Forms.Button get_dep_btn;
		private System.Windows.Forms.ToolTip get_dep_tip;
		private System.Windows.Forms.Button exec_btn;
	}
}

