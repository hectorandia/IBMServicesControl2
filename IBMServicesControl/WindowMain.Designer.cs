namespace IBMServicesControl
{
    partial class WindowMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBottom = new MetroFramework.Controls.MetroPanel();
            this.DisableBtn = new MetroFramework.Controls.MetroButton();
            this.EnableBtn = new MetroFramework.Controls.MetroButton();
            this.stopBtn = new MetroFramework.Controls.MetroButton();
            this.startBtn = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop = new MetroFramework.Controls.MetroPanel();
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.searchBtn = new MetroFramework.Controls.MetroButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.pinTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pingBtn = new MetroFramework.Controls.MetroButton();
            this.selectServerTypComBox = new MetroFramework.Controls.MetroComboBox();
            this.selectServTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.selectServiceComBox = new MetroFramework.Controls.MetroComboBox();
            this.selectServiceLabel = new MetroFramework.Controls.MetroLabel();
            this.selectServerComBox = new MetroFramework.Controls.MetroComboBox();
            this.selectServerLabel = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openServerFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openServicesFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            resources.ApplyResources(this.panelBottom, "panelBottom");
            this.panelBottom.Controls.Add(this.DisableBtn);
            this.panelBottom.Controls.Add(this.EnableBtn);
            this.panelBottom.Controls.Add(this.stopBtn);
            this.panelBottom.Controls.Add(this.startBtn);
            this.panelBottom.HorizontalScrollbar = true;
            this.panelBottom.HorizontalScrollbarBarColor = true;
            this.panelBottom.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBottom.HorizontalScrollbarSize = 12;
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.VerticalScrollbar = true;
            this.panelBottom.VerticalScrollbarBarColor = true;
            this.panelBottom.VerticalScrollbarHighlightOnWheel = false;
            this.panelBottom.VerticalScrollbarSize = 13;
            // 
            // DisableBtn
            // 
            resources.ApplyResources(this.DisableBtn, "DisableBtn");
            this.DisableBtn.Name = "DisableBtn";
            this.DisableBtn.UseSelectable = true;
            this.DisableBtn.Click += new System.EventHandler(this.DisableBtn_Click);
            // 
            // EnableBtn
            // 
            resources.ApplyResources(this.EnableBtn, "EnableBtn");
            this.EnableBtn.Name = "EnableBtn";
            this.EnableBtn.UseSelectable = true;
            this.EnableBtn.Click += new System.EventHandler(this.EnableBtn_Click);
            // 
            // stopBtn
            // 
            resources.ApplyResources(this.stopBtn, "stopBtn");
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.UseSelectable = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            resources.ApplyResources(this.startBtn, "startBtn");
            this.startBtn.Name = "startBtn";
            this.startBtn.UseSelectable = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Place,
            this.serverName,
            this.serviceName,
            this.startType,
            this.state});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Select.FalseValue = "false";
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Select.Frozen = true;
            resources.ApplyResources(this.Select, "Select");
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Select.TrueValue = "true";
            // 
            // Place
            // 
            this.Place.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Place.FillWeight = 340.1361F;
            resources.ApplyResources(this.Place, "Place");
            this.Place.Name = "Place";
            // 
            // serverName
            // 
            this.serverName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.serverName, "serverName");
            this.serverName.Name = "serverName";
            // 
            // serviceName
            // 
            this.serviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.serviceName, "serviceName");
            this.serviceName.Name = "serviceName";
            // 
            // startType
            // 
            this.startType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.startType, "startType");
            this.startType.Name = "startType";
            // 
            // state
            // 
            this.state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.state.FillWeight = 108.8435F;
            resources.ApplyResources(this.state, "state");
            this.state.Name = "state";
            // 
            // panelTop
            // 
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.saveBtn);
            this.panelTop.Controls.Add(this.cancelBtn);
            this.panelTop.Controls.Add(this.searchBtn);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pinTextBox);
            this.panelTop.Controls.Add(this.pingBtn);
            this.panelTop.Controls.Add(this.selectServerTypComBox);
            this.panelTop.Controls.Add(this.selectServTypeLabel);
            this.panelTop.Controls.Add(this.selectServiceComBox);
            this.panelTop.Controls.Add(this.selectServiceLabel);
            this.panelTop.Controls.Add(this.selectServerComBox);
            this.panelTop.Controls.Add(this.selectServerLabel);
            this.panelTop.HorizontalScrollbar = true;
            this.panelTop.HorizontalScrollbarBarColor = true;
            this.panelTop.HorizontalScrollbarHighlightOnWheel = false;
            this.panelTop.HorizontalScrollbarSize = 12;
            this.panelTop.Name = "panelTop";
            this.panelTop.VerticalScrollbar = true;
            this.panelTop.VerticalScrollbarBarColor = true;
            this.panelTop.VerticalScrollbarHighlightOnWheel = false;
            this.panelTop.VerticalScrollbarSize = 13;
            // 
            // saveBtn
            // 
            resources.ApplyResources(this.saveBtn, "saveBtn");
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            resources.ApplyResources(this.cancelBtn, "cancelBtn");
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.UseSelectable = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // searchBtn
            // 
            resources.ApplyResources(this.searchBtn, "searchBtn");
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchBtn.UseSelectable = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pinTextBox
            // 
            resources.ApplyResources(this.pinTextBox, "pinTextBox");
            // 
            // 
            // 
            this.pinTextBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.pinTextBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.pinTextBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.pinTextBox.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin")));
            this.pinTextBox.CustomButton.Name = "";
            this.pinTextBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.pinTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pinTextBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.pinTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pinTextBox.CustomButton.UseSelectable = true;
            this.pinTextBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.pinTextBox.Lines = new string[0];
            this.pinTextBox.MaxLength = 32767;
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.PasswordChar = '\0';
            this.pinTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pinTextBox.SelectedText = "";
            this.pinTextBox.SelectionLength = 0;
            this.pinTextBox.SelectionStart = 0;
            this.pinTextBox.ShortcutsEnabled = true;
            this.pinTextBox.UseSelectable = true;
            this.pinTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pinTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.pinTextBox.TextChanged += new System.EventHandler(this.pinTextBox_TextChanged);
            // 
            // pingBtn
            // 
            resources.ApplyResources(this.pingBtn, "pingBtn");
            this.pingBtn.Name = "pingBtn";
            this.pingBtn.UseSelectable = true;
            this.pingBtn.Click += new System.EventHandler(this.pingBtn_Click);
            // 
            // selectServerTypComBox
            // 
            this.selectServerTypComBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.selectServerTypComBox.FormattingEnabled = true;
            resources.ApplyResources(this.selectServerTypComBox, "selectServerTypComBox");
            this.selectServerTypComBox.Name = "selectServerTypComBox";
            this.selectServerTypComBox.UseSelectable = true;
            this.selectServerTypComBox.SelectedIndexChanged += new System.EventHandler(this.SelectTypComBox_SelectedIndexChanged);
            // 
            // selectServTypeLabel
            // 
            resources.ApplyResources(this.selectServTypeLabel, "selectServTypeLabel");
            this.selectServTypeLabel.Name = "selectServTypeLabel";
            // 
            // selectServiceComBox
            // 
            this.selectServiceComBox.FormattingEnabled = true;
            resources.ApplyResources(this.selectServiceComBox, "selectServiceComBox");
            this.selectServiceComBox.Name = "selectServiceComBox";
            this.selectServiceComBox.UseSelectable = true;
            this.selectServiceComBox.SelectedIndexChanged += new System.EventHandler(this.selectServiceComBox_SelectedIndexChanged);
            // 
            // selectServiceLabel
            // 
            resources.ApplyResources(this.selectServiceLabel, "selectServiceLabel");
            this.selectServiceLabel.Name = "selectServiceLabel";
            // 
            // selectServerComBox
            // 
            this.selectServerComBox.FormattingEnabled = true;
            resources.ApplyResources(this.selectServerComBox, "selectServerComBox");
            this.selectServerComBox.Name = "selectServerComBox";
            this.selectServerComBox.UseSelectable = true;
            this.selectServerComBox.SelectedIndexChanged += new System.EventHandler(this.selectServerComBox_SelectedIndexChanged);
            // 
            // selectServerLabel
            // 
            resources.ApplyResources(this.selectServerLabel, "selectServerLabel");
            this.selectServerLabel.Name = "selectServerLabel";
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serversToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            resources.ApplyResources(this.serversToolStripMenuItem, "serversToolStripMenuItem");
            this.serversToolStripMenuItem.Click += new System.EventHandler(this.serversToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            resources.ApplyResources(this.servicesToolStripMenuItem, "servicesToolStripMenuItem");
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // saveStripMenuItem1
            // 
            this.saveStripMenuItem1.Name = "saveStripMenuItem1";
            resources.ApplyResources(this.saveStripMenuItem1, "saveStripMenuItem1");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // WindowMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WindowMain";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WindowMain_FormClosed);
            this.Load += new System.EventHandler(this.WindowMain_Load);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Panel panelBottom;
        //private System.Windows.Forms.Button restartBtn;
        //private System.Windows.Forms.Button stopBtn;
        //private System.Windows.Forms.Button startBtn;
        private MetroFramework.Controls.MetroPanel panelBottom;
        private MetroFramework.Controls.MetroButton stopBtn;
        private MetroFramework.Controls.MetroButton startBtn;
        //private System.Windows.Forms.Label selectServerLabel;
        private MetroFramework.Controls.MetroLabel selectServerLabel;
        //private System.Windows.Forms.ComboBox selectServerComBox;
        private MetroFramework.Controls.MetroComboBox selectServerComBox;
        //private System.Windows.Forms.Label selectServiceLabel;
        private MetroFramework.Controls.MetroLabel selectServiceLabel;
        //private System.Windows.Forms.ComboBox selectServiceComBox;
        //private System.Windows.Forms.ComboBox selectServerTypComBox;
        private MetroFramework.Controls.MetroComboBox selectServiceComBox;
        private MetroFramework.Controls.MetroComboBox selectServerTypComBox;
        //private System.Windows.Forms.Label selectServTypeLabel;
        private MetroFramework.Controls.MetroLabel selectServTypeLabel;
        //private System.Windows.Forms.Button searchBtn;
        private MetroFramework.Controls.MetroButton searchBtn;
        //private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel label1;
        //private System.Windows.Forms.TextBox pinTextBox;
        private MetroFramework.Controls.MetroTextBox pinTextBox;
        //private System.Windows.Forms.Button pingBtn;
        //private System.Windows.Forms.Button DisableBtn;
        //private System.Windows.Forms.Button EnableBtn;
        //private System.Windows.Forms.Panel panelTop;        
        private MetroFramework.Controls.MetroButton pingBtn;
        private MetroFramework.Controls.MetroButton DisableBtn;
        private MetroFramework.Controls.MetroButton EnableBtn;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startType;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private MetroFramework.Controls.MetroPanel panelTop;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private MetroFramework.Controls.MetroButton saveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openServerFileDialog1;
        private System.Windows.Forms.OpenFileDialog openServicesFileDialog1;
    }
}

