namespace phpbb3_to_wp
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtWordpressBaseXml = new System.Windows.Forms.TextBox();
            this.btnWordpressBaseXmlBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTablePrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMySQLphpbb3ConnStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetForumList = new System.Windows.Forms.Button();
            this.dgvForumList = new System.Windows.Forms.DataGridView();
            this.tree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forum_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forum_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parent_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parent_Forum_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdoP2ANone = new System.Windows.Forms.RadioButton();
            this.txtP2AReMapping = new System.Windows.Forms.TextBox();
            this.txtP2ADefault = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSelTopics = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtExcludeTopicsID = new System.Windows.Forms.TextBox();
            this.grpSelectedTopics = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSelTopicsTo = new System.Windows.Forms.TextBox();
            this.txtSelTopicsFrom = new System.Windows.Forms.TextBox();
            this.rdoSelTopicsRange = new System.Windows.Forms.RadioButton();
            this.rdoSelTopicsAll = new System.Windows.Forms.RadioButton();
            this.tabBBCodeToHtmlTag = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBBCodeToHtmlTag = new System.Windows.Forms.TextBox();
            this.tabUnmappedBBCodeList = new System.Windows.Forms.TabPage();
            this.lstUnmappedBBCode = new System.Windows.Forms.ListBox();
            this.tabTagList = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTagList = new System.Windows.Forms.TextBox();
            this.tabP2A = new System.Windows.Forms.TabPage();
            this.chkP2AReMapping = new System.Windows.Forms.CheckBox();
            this.chkP2ADefault = new System.Windows.Forms.CheckBox();
            this.tabMisc = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddMoreTagAfterPost = new System.Windows.Forms.TextBox();
            this.chkAddMoreTag = new System.Windows.Forms.CheckBox();
            this.chkShowOriginalLink = new System.Windows.Forms.CheckBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabForumList = new System.Windows.Forms.TabPage();
            this.tabUserList = new System.Windows.Forms.TabPage();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForumList)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSelTopics.SuspendLayout();
            this.grpSelectedTopics.SuspendLayout();
            this.tabBBCodeToHtmlTag.SuspendLayout();
            this.tabUnmappedBBCodeList.SuspendLayout();
            this.tabTagList.SuspendLayout();
            this.tabP2A.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabForumList.SuspendLayout();
            this.tabUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "wordpress_base.xml = ";
            // 
            // txtWordpressBaseXml
            // 
            this.txtWordpressBaseXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWordpressBaseXml.Location = new System.Drawing.Point(131, 484);
            this.txtWordpressBaseXml.Name = "txtWordpressBaseXml";
            this.txtWordpressBaseXml.Size = new System.Drawing.Size(569, 22);
            this.txtWordpressBaseXml.TabIndex = 1;
            this.txtWordpressBaseXml.Text = "wordpress_base.xml";
            // 
            // btnWordpressBaseXmlBrowse
            // 
            this.btnWordpressBaseXmlBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWordpressBaseXmlBrowse.Location = new System.Drawing.Point(706, 482);
            this.btnWordpressBaseXmlBrowse.Name = "btnWordpressBaseXmlBrowse";
            this.btnWordpressBaseXmlBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnWordpressBaseXmlBrowse.TabIndex = 2;
            this.btnWordpressBaseXmlBrowse.Text = "Browse...";
            this.btnWordpressBaseXmlBrowse.UseVisualStyleBackColor = true;
            this.btnWordpressBaseXmlBrowse.Click += new System.EventHandler(this.btnWordpressBaseXmlBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTablePrefix);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMySQLphpbb3ConnStr);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MySQL - phpbb3";
            // 
            // txtTablePrefix
            // 
            this.txtTablePrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTablePrefix.Location = new System.Drawing.Point(99, 43);
            this.txtTablePrefix.Name = "txtTablePrefix";
            this.txtTablePrefix.Size = new System.Drawing.Size(663, 22);
            this.txtTablePrefix.TabIndex = 7;
            this.txtTablePrefix.Text = "phpbb_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "table prefix";
            // 
            // txtMySQLphpbb3ConnStr
            // 
            this.txtMySQLphpbb3ConnStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMySQLphpbb3ConnStr.Location = new System.Drawing.Point(99, 15);
            this.txtMySQLphpbb3ConnStr.Name = "txtMySQLphpbb3ConnStr";
            this.txtMySQLphpbb3ConnStr.Size = new System.Drawing.Size(663, 22);
            this.txtMySQLphpbb3ConnStr.TabIndex = 5;
            this.txtMySQLphpbb3ConnStr.Text = "Server=localhost;Database=phpbb3;Uid=root;Pwd=;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ConnectionString";
            // 
            // btnGetForumList
            // 
            this.btnGetForumList.Location = new System.Drawing.Point(12, 97);
            this.btnGetForumList.Name = "btnGetForumList";
            this.btnGetForumList.Size = new System.Drawing.Size(209, 23);
            this.btnGetForumList.TabIndex = 4;
            this.btnGetForumList.Text = "Get Forum List and User List";
            this.btnGetForumList.UseVisualStyleBackColor = true;
            this.btnGetForumList.Click += new System.EventHandler(this.btnGetForumList_Click);
            // 
            // dgvForumList
            // 
            this.dgvForumList.AllowUserToAddRows = false;
            this.dgvForumList.AllowUserToDeleteRows = false;
            this.dgvForumList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvForumList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForumList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tree,
            this.Forum_ID,
            this.Forum_Name,
            this.Parent_ID,
            this.Parent_Forum_Name});
            this.dgvForumList.Location = new System.Drawing.Point(6, 6);
            this.dgvForumList.MultiSelect = false;
            this.dgvForumList.Name = "dgvForumList";
            this.dgvForumList.ReadOnly = true;
            this.dgvForumList.RowTemplate.Height = 24;
            this.dgvForumList.Size = new System.Drawing.Size(748, 114);
            this.dgvForumList.TabIndex = 5;
            // 
            // tree
            // 
            this.tree.HeaderText = "Tree";
            this.tree.Name = "tree";
            this.tree.ReadOnly = true;
            this.tree.Width = 200;
            // 
            // Forum_ID
            // 
            this.Forum_ID.HeaderText = "Forum ID";
            this.Forum_ID.Name = "Forum_ID";
            this.Forum_ID.ReadOnly = true;
            // 
            // Forum_Name
            // 
            this.Forum_Name.HeaderText = "Forum Name";
            this.Forum_Name.Name = "Forum_Name";
            this.Forum_Name.ReadOnly = true;
            this.Forum_Name.Width = 200;
            // 
            // Parent_ID
            // 
            this.Parent_ID.HeaderText = "Parent ID";
            this.Parent_ID.Name = "Parent_ID";
            this.Parent_ID.ReadOnly = true;
            // 
            // Parent_Forum_Name
            // 
            this.Parent_Forum_Name.HeaderText = "Parent Forum Name";
            this.Parent_Forum_Name.Name = "Parent_Forum_Name";
            this.Parent_Forum_Name.ReadOnly = true;
            this.Parent_Forum_Name.Width = 200;
            // 
            // rdoP2ANone
            // 
            this.rdoP2ANone.AutoSize = true;
            this.rdoP2ANone.Location = new System.Drawing.Point(6, 6);
            this.rdoP2ANone.Name = "rdoP2ANone";
            this.rdoP2ANone.Size = new System.Drawing.Size(48, 16);
            this.rdoP2ANone.TabIndex = 4;
            this.rdoP2ANone.Text = "None";
            this.rdoP2ANone.UseVisualStyleBackColor = true;
            this.rdoP2ANone.CheckedChanged += new System.EventHandler(this.rdoP2ANone_CheckedChanged);
            // 
            // txtP2AReMapping
            // 
            this.txtP2AReMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtP2AReMapping.Location = new System.Drawing.Point(91, 55);
            this.txtP2AReMapping.Multiline = true;
            this.txtP2AReMapping.Name = "txtP2AReMapping";
            this.txtP2AReMapping.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtP2AReMapping.Size = new System.Drawing.Size(663, 105);
            this.txtP2AReMapping.TabIndex = 3;
            this.txtP2AReMapping.Text = "auther1=posterA,posterB\r\nauther2=posterX,posterY,posterZ\r\n";
            // 
            // txtP2ADefault
            // 
            this.txtP2ADefault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtP2ADefault.Location = new System.Drawing.Point(91, 27);
            this.txtP2ADefault.Name = "txtP2ADefault";
            this.txtP2ADefault.Size = new System.Drawing.Size(663, 22);
            this.txtP2ADefault.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(478, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "output file name = wordpress_base_<forum_id>_<selecte_topics>_<forum_name>.xml @ " +
    "startup path";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(13, 538);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(768, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabSelTopics);
            this.tabControl1.Controls.Add(this.tabBBCodeToHtmlTag);
            this.tabControl1.Controls.Add(this.tabUnmappedBBCodeList);
            this.tabControl1.Controls.Add(this.tabTagList);
            this.tabControl1.Controls.Add(this.tabP2A);
            this.tabControl1.Controls.Add(this.tabMisc);
            this.tabControl1.Location = new System.Drawing.Point(12, 284);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 192);
            this.tabControl1.TabIndex = 9;
            // 
            // tabSelTopics
            // 
            this.tabSelTopics.Controls.Add(this.label11);
            this.tabSelTopics.Controls.Add(this.txtExcludeTopicsID);
            this.tabSelTopics.Controls.Add(this.grpSelectedTopics);
            this.tabSelTopics.Location = new System.Drawing.Point(4, 22);
            this.tabSelTopics.Name = "tabSelTopics";
            this.tabSelTopics.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelTopics.Size = new System.Drawing.Size(760, 166);
            this.tabSelTopics.TabIndex = 5;
            this.tabSelTopics.Text = "Selected Topics";
            this.tabSelTopics.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "Exclude Topics ID : delimter by ,";
            // 
            // txtExcludeTopicsID
            // 
            this.txtExcludeTopicsID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcludeTopicsID.Location = new System.Drawing.Point(6, 98);
            this.txtExcludeTopicsID.Multiline = true;
            this.txtExcludeTopicsID.Name = "txtExcludeTopicsID";
            this.txtExcludeTopicsID.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExcludeTopicsID.Size = new System.Drawing.Size(748, 62);
            this.txtExcludeTopicsID.TabIndex = 1;
            // 
            // grpSelectedTopics
            // 
            this.grpSelectedTopics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSelectedTopics.Controls.Add(this.label10);
            this.grpSelectedTopics.Controls.Add(this.txtSelTopicsTo);
            this.grpSelectedTopics.Controls.Add(this.txtSelTopicsFrom);
            this.grpSelectedTopics.Controls.Add(this.rdoSelTopicsRange);
            this.grpSelectedTopics.Controls.Add(this.rdoSelTopicsAll);
            this.grpSelectedTopics.Location = new System.Drawing.Point(6, 6);
            this.grpSelectedTopics.Name = "grpSelectedTopics";
            this.grpSelectedTopics.Size = new System.Drawing.Size(748, 74);
            this.grpSelectedTopics.TabIndex = 0;
            this.grpSelectedTopics.TabStop = false;
            this.grpSelectedTopics.Text = "Selected Topics";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "to";
            // 
            // txtSelTopicsTo
            // 
            this.txtSelTopicsTo.Location = new System.Drawing.Point(225, 42);
            this.txtSelTopicsTo.Name = "txtSelTopicsTo";
            this.txtSelTopicsTo.Size = new System.Drawing.Size(38, 22);
            this.txtSelTopicsTo.TabIndex = 3;
            this.txtSelTopicsTo.Text = "9999";
            // 
            // txtSelTopicsFrom
            // 
            this.txtSelTopicsFrom.Location = new System.Drawing.Point(161, 42);
            this.txtSelTopicsFrom.Name = "txtSelTopicsFrom";
            this.txtSelTopicsFrom.Size = new System.Drawing.Size(38, 22);
            this.txtSelTopicsFrom.TabIndex = 2;
            this.txtSelTopicsFrom.Text = "0";
            // 
            // rdoSelTopicsRange
            // 
            this.rdoSelTopicsRange.AutoSize = true;
            this.rdoSelTopicsRange.Location = new System.Drawing.Point(6, 43);
            this.rdoSelTopicsRange.Name = "rdoSelTopicsRange";
            this.rdoSelTopicsRange.Size = new System.Drawing.Size(149, 16);
            this.rdoSelTopicsRange.TabIndex = 1;
            this.rdoSelTopicsRange.Text = "Range : Topics Index from";
            this.rdoSelTopicsRange.UseVisualStyleBackColor = true;
            // 
            // rdoSelTopicsAll
            // 
            this.rdoSelTopicsAll.AutoSize = true;
            this.rdoSelTopicsAll.Checked = true;
            this.rdoSelTopicsAll.Location = new System.Drawing.Point(6, 21);
            this.rdoSelTopicsAll.Name = "rdoSelTopicsAll";
            this.rdoSelTopicsAll.Size = new System.Drawing.Size(37, 16);
            this.rdoSelTopicsAll.TabIndex = 0;
            this.rdoSelTopicsAll.TabStop = true;
            this.rdoSelTopicsAll.Text = "All";
            this.rdoSelTopicsAll.UseVisualStyleBackColor = true;
            // 
            // tabBBCodeToHtmlTag
            // 
            this.tabBBCodeToHtmlTag.Controls.Add(this.label8);
            this.tabBBCodeToHtmlTag.Controls.Add(this.label7);
            this.tabBBCodeToHtmlTag.Controls.Add(this.label6);
            this.tabBBCodeToHtmlTag.Controls.Add(this.txtBBCodeToHtmlTag);
            this.tabBBCodeToHtmlTag.Location = new System.Drawing.Point(4, 22);
            this.tabBBCodeToHtmlTag.Name = "tabBBCodeToHtmlTag";
            this.tabBBCodeToHtmlTag.Padding = new System.Windows.Forms.Padding(3);
            this.tabBBCodeToHtmlTag.Size = new System.Drawing.Size(760, 166);
            this.tabBBCodeToHtmlTag.TabIndex = 2;
            this.tabBBCodeToHtmlTag.Text = "BBCode To Html Tag";
            this.tabBBCodeToHtmlTag.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(504, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "reversed content use %%TEXT1%%, %%TEXT2%% (ex. [url=%%TEXT1%%]=<a href=\"%%TEXT1%%" +
    "\">";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "format: [bbcode]=<html tag> (ex: [b]=<strong>)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "one line one BBCode";
            // 
            // txtBBCodeToHtmlTag
            // 
            this.txtBBCodeToHtmlTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBBCodeToHtmlTag.Location = new System.Drawing.Point(6, 42);
            this.txtBBCodeToHtmlTag.Multiline = true;
            this.txtBBCodeToHtmlTag.Name = "txtBBCodeToHtmlTag";
            this.txtBBCodeToHtmlTag.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBBCodeToHtmlTag.Size = new System.Drawing.Size(748, 118);
            this.txtBBCodeToHtmlTag.TabIndex = 1;
            // 
            // tabUnmappedBBCodeList
            // 
            this.tabUnmappedBBCodeList.Controls.Add(this.lstUnmappedBBCode);
            this.tabUnmappedBBCodeList.Location = new System.Drawing.Point(4, 22);
            this.tabUnmappedBBCodeList.Name = "tabUnmappedBBCodeList";
            this.tabUnmappedBBCodeList.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnmappedBBCodeList.Size = new System.Drawing.Size(760, 166);
            this.tabUnmappedBBCodeList.TabIndex = 3;
            this.tabUnmappedBBCodeList.Text = "Unmapped BBCode List";
            this.tabUnmappedBBCodeList.UseVisualStyleBackColor = true;
            // 
            // lstUnmappedBBCode
            // 
            this.lstUnmappedBBCode.FormattingEnabled = true;
            this.lstUnmappedBBCode.ItemHeight = 12;
            this.lstUnmappedBBCode.Location = new System.Drawing.Point(6, 6);
            this.lstUnmappedBBCode.Name = "lstUnmappedBBCode";
            this.lstUnmappedBBCode.Size = new System.Drawing.Size(748, 148);
            this.lstUnmappedBBCode.TabIndex = 0;
            // 
            // tabTagList
            // 
            this.tabTagList.Controls.Add(this.label5);
            this.tabTagList.Controls.Add(this.txtTagList);
            this.tabTagList.Location = new System.Drawing.Point(4, 22);
            this.tabTagList.Name = "tabTagList";
            this.tabTagList.Padding = new System.Windows.Forms.Padding(3);
            this.tabTagList.Size = new System.Drawing.Size(760, 166);
            this.tabTagList.TabIndex = 1;
            this.tabTagList.Text = "TagList";
            this.tabTagList.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "one line one Tag";
            // 
            // txtTagList
            // 
            this.txtTagList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTagList.Location = new System.Drawing.Point(6, 18);
            this.txtTagList.Multiline = true;
            this.txtTagList.Name = "txtTagList";
            this.txtTagList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTagList.Size = new System.Drawing.Size(748, 133);
            this.txtTagList.TabIndex = 0;
            // 
            // tabP2A
            // 
            this.tabP2A.Controls.Add(this.chkP2AReMapping);
            this.tabP2A.Controls.Add(this.chkP2ADefault);
            this.tabP2A.Controls.Add(this.rdoP2ANone);
            this.tabP2A.Controls.Add(this.txtP2ADefault);
            this.tabP2A.Controls.Add(this.txtP2AReMapping);
            this.tabP2A.Location = new System.Drawing.Point(4, 22);
            this.tabP2A.Name = "tabP2A";
            this.tabP2A.Padding = new System.Windows.Forms.Padding(3);
            this.tabP2A.Size = new System.Drawing.Size(760, 166);
            this.tabP2A.TabIndex = 0;
            this.tabP2A.Text = "Poster re-mapping";
            this.tabP2A.UseVisualStyleBackColor = true;
            // 
            // chkP2AReMapping
            // 
            this.chkP2AReMapping.AutoSize = true;
            this.chkP2AReMapping.Location = new System.Drawing.Point(6, 57);
            this.chkP2AReMapping.Name = "chkP2AReMapping";
            this.chkP2AReMapping.Size = new System.Drawing.Size(82, 16);
            this.chkP2AReMapping.TabIndex = 6;
            this.chkP2AReMapping.Text = "Re-mapping";
            this.chkP2AReMapping.UseVisualStyleBackColor = true;
            this.chkP2AReMapping.CheckedChanged += new System.EventHandler(this.chkP2AReMapping_CheckedChanged);
            // 
            // chkP2ADefault
            // 
            this.chkP2ADefault.AutoSize = true;
            this.chkP2ADefault.Checked = true;
            this.chkP2ADefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkP2ADefault.Location = new System.Drawing.Point(6, 29);
            this.chkP2ADefault.Name = "chkP2ADefault";
            this.chkP2ADefault.Size = new System.Drawing.Size(58, 16);
            this.chkP2ADefault.TabIndex = 5;
            this.chkP2ADefault.Text = "Default";
            this.chkP2ADefault.UseVisualStyleBackColor = true;
            this.chkP2ADefault.CheckedChanged += new System.EventHandler(this.chkP2ADefault_CheckedChanged);
            // 
            // tabMisc
            // 
            this.tabMisc.Controls.Add(this.label9);
            this.tabMisc.Controls.Add(this.txtAddMoreTagAfterPost);
            this.tabMisc.Controls.Add(this.chkAddMoreTag);
            this.tabMisc.Controls.Add(this.chkShowOriginalLink);
            this.tabMisc.Location = new System.Drawing.Point(4, 22);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tabMisc.Size = new System.Drawing.Size(760, 166);
            this.tabMisc.TabIndex = 4;
            this.tabMisc.Text = "Misc.";
            this.tabMisc.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "posts";
            // 
            // txtAddMoreTagAfterPost
            // 
            this.txtAddMoreTagAfterPost.Location = new System.Drawing.Point(126, 27);
            this.txtAddMoreTagAfterPost.Name = "txtAddMoreTagAfterPost";
            this.txtAddMoreTagAfterPost.Size = new System.Drawing.Size(39, 22);
            this.txtAddMoreTagAfterPost.TabIndex = 2;
            this.txtAddMoreTagAfterPost.Text = "1";
            // 
            // chkAddMoreTag
            // 
            this.chkAddMoreTag.AutoSize = true;
            this.chkAddMoreTag.Checked = true;
            this.chkAddMoreTag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddMoreTag.Location = new System.Drawing.Point(7, 29);
            this.chkAddMoreTag.Name = "chkAddMoreTag";
            this.chkAddMoreTag.Size = new System.Drawing.Size(113, 16);
            this.chkAddMoreTag.TabIndex = 1;
            this.chkAddMoreTag.Text = "Add More tag after";
            this.chkAddMoreTag.UseVisualStyleBackColor = true;
            // 
            // chkShowOriginalLink
            // 
            this.chkShowOriginalLink.AutoSize = true;
            this.chkShowOriginalLink.Checked = true;
            this.chkShowOriginalLink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowOriginalLink.Location = new System.Drawing.Point(6, 6);
            this.chkShowOriginalLink.Name = "chkShowOriginalLink";
            this.chkShowOriginalLink.Size = new System.Drawing.Size(159, 16);
            this.chkShowOriginalLink.TabIndex = 0;
            this.chkShowOriginalLink.Text = "Show Original phpBB3 Link";
            this.chkShowOriginalLink.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabForumList);
            this.tabControl2.Controls.Add(this.tabUserList);
            this.tabControl2.Location = new System.Drawing.Point(12, 126);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(768, 152);
            this.tabControl2.TabIndex = 10;
            // 
            // tabForumList
            // 
            this.tabForumList.Controls.Add(this.dgvForumList);
            this.tabForumList.Location = new System.Drawing.Point(4, 22);
            this.tabForumList.Name = "tabForumList";
            this.tabForumList.Padding = new System.Windows.Forms.Padding(3);
            this.tabForumList.Size = new System.Drawing.Size(760, 126);
            this.tabForumList.TabIndex = 0;
            this.tabForumList.Text = "Forum List";
            this.tabForumList.UseVisualStyleBackColor = true;
            // 
            // tabUserList
            // 
            this.tabUserList.Controls.Add(this.dgvUserList);
            this.tabUserList.Location = new System.Drawing.Point(4, 22);
            this.tabUserList.Name = "tabUserList";
            this.tabUserList.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserList.Size = new System.Drawing.Size(760, 126);
            this.tabUserList.TabIndex = 1;
            this.tabUserList.Text = "User List";
            this.tabUserList.UseVisualStyleBackColor = true;
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flag,
            this.UserName,
            this.UserEMail,
            this.UserID});
            this.dgvUserList.Location = new System.Drawing.Point(6, 6);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.RowTemplate.Height = 24;
            this.dgvUserList.Size = new System.Drawing.Size(748, 117);
            this.dgvUserList.TabIndex = 0;
            // 
            // Flag
            // 
            this.Flag.HeaderText = "*";
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            this.Flag.Width = 20;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UserEMail
            // 
            this.UserEMail.HeaderText = "e-mail";
            this.UserEMail.Name = "UserEMail";
            this.UserEMail.ReadOnly = true;
            this.UserEMail.Width = 300;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "User ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGetForumList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnWordpressBaseXmlBrowse);
            this.Controls.Add(this.txtWordpressBaseXml);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "phpbb3 to wp - v1.0.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForumList)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSelTopics.ResumeLayout(false);
            this.tabSelTopics.PerformLayout();
            this.grpSelectedTopics.ResumeLayout(false);
            this.grpSelectedTopics.PerformLayout();
            this.tabBBCodeToHtmlTag.ResumeLayout(false);
            this.tabBBCodeToHtmlTag.PerformLayout();
            this.tabUnmappedBBCodeList.ResumeLayout(false);
            this.tabTagList.ResumeLayout(false);
            this.tabTagList.PerformLayout();
            this.tabP2A.ResumeLayout(false);
            this.tabP2A.PerformLayout();
            this.tabMisc.ResumeLayout(false);
            this.tabMisc.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabForumList.ResumeLayout(false);
            this.tabUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWordpressBaseXml;
        private System.Windows.Forms.Button btnWordpressBaseXmlBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMySQLphpbb3ConnStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTablePrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetForumList;
        private System.Windows.Forms.DataGridView dgvForumList;
        private System.Windows.Forms.DataGridViewTextBoxColumn tree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forum_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forum_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parent_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parent_Forum_Name;
        private System.Windows.Forms.TextBox txtP2ADefault;
        private System.Windows.Forms.TextBox txtP2AReMapping;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton rdoP2ANone;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabP2A;
        private System.Windows.Forms.TabPage tabTagList;
        private System.Windows.Forms.TextBox txtTagList;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabForumList;
        private System.Windows.Forms.TabPage tabUserList;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.CheckBox chkP2AReMapping;
        private System.Windows.Forms.CheckBox chkP2ADefault;
        private System.Windows.Forms.TabPage tabBBCodeToHtmlTag;
        private System.Windows.Forms.TextBox txtBBCodeToHtmlTag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabUnmappedBBCodeList;
        private System.Windows.Forms.TabPage tabMisc;
        private System.Windows.Forms.CheckBox chkShowOriginalLink;
        private System.Windows.Forms.ListBox lstUnmappedBBCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddMoreTagAfterPost;
        private System.Windows.Forms.CheckBox chkAddMoreTag;
        private System.Windows.Forms.TabPage tabSelTopics;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtExcludeTopicsID;
        private System.Windows.Forms.GroupBox grpSelectedTopics;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSelTopicsTo;
        private System.Windows.Forms.TextBox txtSelTopicsFrom;
        private System.Windows.Forms.RadioButton rdoSelTopicsRange;
        private System.Windows.Forms.RadioButton rdoSelTopicsAll;
    }
}

