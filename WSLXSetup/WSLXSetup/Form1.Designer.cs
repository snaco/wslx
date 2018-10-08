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
			this.gen_cfg_btn = new System.Windows.Forms.Button();
			this.xsrvc_label = new System.Windows.Forms.Label();
			this.wsl_distro = new System.Windows.Forms.ComboBox();
			this.window_manager = new System.Windows.Forms.ComboBox();
			this.distro_label = new System.Windows.Forms.Label();
			this.windowmgr_label = new System.Windows.Forms.Label();
			this.get_dep_btn = new System.Windows.Forms.Button();
			this.get_dep_tip = new System.Windows.Forms.ToolTip(this.components);
			this.exec_btn = new System.Windows.Forms.Button();
			this.log_path_tbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.set_folder_btn = new System.Windows.Forms.Button();
			this.logfile_tip = new System.Windows.Forms.ToolTip(this.components);
			this.set_logfie_output = new System.Windows.Forms.FolderBrowserDialog();
			this.term_list = new System.Windows.Forms.ComboBox();
			this.term_label = new System.Windows.Forms.Label();
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
			this.xserver_client.Location = new System.Drawing.Point(12, 31);
			this.xserver_client.Name = "xserver_client";
			this.xserver_client.Size = new System.Drawing.Size(153, 24);
			this.xserver_client.TabIndex = 0;
			// 
			// gen_cfg_btn
			// 
			this.gen_cfg_btn.BackColor = System.Drawing.Color.Turquoise;
			this.gen_cfg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gen_cfg_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.gen_cfg_btn.Location = new System.Drawing.Point(264, 112);
			this.gen_cfg_btn.Name = "gen_cfg_btn";
			this.gen_cfg_btn.Size = new System.Drawing.Size(153, 51);
			this.gen_cfg_btn.TabIndex = 1;
			this.gen_cfg_btn.Text = "Generate Config";
			this.gen_cfg_btn.UseVisualStyleBackColor = false;
			this.gen_cfg_btn.Click += new System.EventHandler(this.generate_config);
			// 
			// xsrvc_label
			// 
			this.xsrvc_label.AutoSize = true;
			this.xsrvc_label.Location = new System.Drawing.Point(12, 11);
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
            "Ubuntu 16.04",
            "Ubuntu 18.04",
            "Debian GNU/Linux",
            "openSUSE Leap 42",
            "Kali",
            "WLinux"});
			this.wsl_distro.Location = new System.Drawing.Point(170, 31);
			this.wsl_distro.Name = "wsl_distro";
			this.wsl_distro.Size = new System.Drawing.Size(182, 24);
			this.wsl_distro.TabIndex = 3;
			this.wsl_distro.SelectedIndexChanged += new System.EventHandler(this.wsl_distro_SelectedIndexChanged);
			// 
			// window_manager
			// 
			this.window_manager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.window_manager.FormattingEnabled = true;
			this.window_manager.Items.AddRange(new object[] {
            "i3",
            "xfce"});
			this.window_manager.Location = new System.Drawing.Point(358, 31);
			this.window_manager.Name = "window_manager";
			this.window_manager.Size = new System.Drawing.Size(121, 24);
			this.window_manager.TabIndex = 4;
			this.window_manager.SelectedIndexChanged += new System.EventHandler(this.window_manager_SelectedIndexChanged);
			// 
			// distro_label
			// 
			this.distro_label.AutoSize = true;
			this.distro_label.Location = new System.Drawing.Point(167, 11);
			this.distro_label.Name = "distro_label";
			this.distro_label.Size = new System.Drawing.Size(79, 17);
			this.distro_label.TabIndex = 5;
			this.distro_label.Text = "WSL Distro";
			// 
			// windowmgr_label
			// 
			this.windowmgr_label.AutoSize = true;
			this.windowmgr_label.Location = new System.Drawing.Point(355, 11);
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
			this.get_dep_btn.Location = new System.Drawing.Point(12, 112);
			this.get_dep_btn.Name = "get_dep_btn";
			this.get_dep_btn.Size = new System.Drawing.Size(246, 51);
			this.get_dep_btn.TabIndex = 7;
			this.get_dep_btn.Text = "Install WM and Generate Config";
			this.get_dep_btn.UseVisualStyleBackColor = false;
			this.get_dep_btn.Click += new System.EventHandler(this.get_dep_btn_Click);
			// 
			// get_dep_tip
			// 
			this.get_dep_tip.AutoPopDelay = 500000;
			this.get_dep_tip.InitialDelay = 500;
			this.get_dep_tip.ReshowDelay = 100;
			this.get_dep_tip.ShowAlways = true;
			this.get_dep_tip.ToolTipTitle = "Install Window Manager";
			// 
			// exec_btn
			// 
			this.exec_btn.BackColor = System.Drawing.Color.Firebrick;
			this.exec_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exec_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.exec_btn.Location = new System.Drawing.Point(423, 112);
			this.exec_btn.Name = "exec_btn";
			this.exec_btn.Size = new System.Drawing.Size(182, 51);
			this.exec_btn.TabIndex = 8;
			this.exec_btn.Text = "Exit and Run WSLX";
			this.exec_btn.UseVisualStyleBackColor = false;
			this.exec_btn.Click += new System.EventHandler(this.exec_btn_Click);
			// 
			// log_path_tbox
			// 
			this.log_path_tbox.Location = new System.Drawing.Point(184, 74);
			this.log_path_tbox.Name = "log_path_tbox";
			this.log_path_tbox.Size = new System.Drawing.Size(421, 22);
			this.log_path_tbox.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 17);
			this.label1.TabIndex = 11;
			this.label1.Text = "Logfile";
			// 
			// set_folder_btn
			// 
			this.set_folder_btn.BackColor = System.Drawing.SystemColors.HotTrack;
			this.set_folder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.set_folder_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.set_folder_btn.Location = new System.Drawing.Point(68, 70);
			this.set_folder_btn.Name = "set_folder_btn";
			this.set_folder_btn.Size = new System.Drawing.Size(110, 30);
			this.set_folder_btn.TabIndex = 12;
			this.set_folder_btn.Text = "Set Directory";
			this.set_folder_btn.UseVisualStyleBackColor = false;
			this.set_folder_btn.Click += new System.EventHandler(this.set_folder_btn_Click);
			// 
			// logfile_tip
			// 
			this.logfile_tip.ToolTipTitle = "Logfile";
			// 
			// set_logfie_output
			// 
			this.set_logfie_output.HelpRequest += new System.EventHandler(this.set_logfie_output_HelpRequest);
			// 
			// term_list
			// 
			this.term_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.term_list.FormattingEnabled = true;
			this.term_list.Location = new System.Drawing.Point(485, 31);
			this.term_list.Name = "term_list";
			this.term_list.Size = new System.Drawing.Size(121, 24);
			this.term_list.TabIndex = 13;
			// 
			// term_label
			// 
			this.term_label.AutoSize = true;
			this.term_label.Location = new System.Drawing.Point(482, 11);
			this.term_label.Name = "term_label";
			this.term_label.Size = new System.Drawing.Size(123, 17);
			this.term_label.TabIndex = 14;
			this.term_label.Text = "Terminal Emulator";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowText;
			this.ClientSize = new System.Drawing.Size(619, 177);
			this.Controls.Add(this.term_label);
			this.Controls.Add(this.term_list);
			this.Controls.Add(this.set_folder_btn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.log_path_tbox);
			this.Controls.Add(this.exec_btn);
			this.Controls.Add(this.get_dep_btn);
			this.Controls.Add(this.windowmgr_label);
			this.Controls.Add(this.distro_label);
			this.Controls.Add(this.window_manager);
			this.Controls.Add(this.wsl_distro);
			this.Controls.Add(this.xsrvc_label);
			this.Controls.Add(this.gen_cfg_btn);
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
		private System.Windows.Forms.Button gen_cfg_btn;
		private System.Windows.Forms.Label xsrvc_label;
		private System.Windows.Forms.ComboBox wsl_distro;
		private System.Windows.Forms.ComboBox window_manager;
		private System.Windows.Forms.Label distro_label;
		private System.Windows.Forms.Label windowmgr_label;
		private System.Windows.Forms.Button get_dep_btn;
		private System.Windows.Forms.ToolTip get_dep_tip;
		private System.Windows.Forms.Button exec_btn;
		private System.Windows.Forms.TextBox log_path_tbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button set_folder_btn;
		private System.Windows.Forms.ToolTip logfile_tip;
		private System.Windows.Forms.FolderBrowserDialog set_logfie_output;
		private System.Windows.Forms.ComboBox term_list;
		private System.Windows.Forms.Label term_label;
	}
}

