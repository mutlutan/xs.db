namespace xs.db
{
    partial class frmSQLsEditor
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
            this.label_Select = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Select = new System.Windows.Forms.TextBox();
            this.textBox_From = new System.Windows.Forms.TextBox();
            this.textBox_Where = new System.Windows.Forms.TextBox();
            this.textBox_GroupBy = new System.Windows.Forms.TextBox();
            this.textBox_OrderBy = new System.Windows.Forms.TextBox();
            this.textBox_Having = new System.Windows.Forms.TextBox();
            this.label_From = new System.Windows.Forms.Label();
            this.label_Where = new System.Windows.Forms.Label();
            this.label_GroupBy = new System.Windows.Forms.Label();
            this.label_Having = new System.Windows.Forms.Label();
            this.label_OrderBy = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_QueryResult = new System.Windows.Forms.Button();
            this.tabControl_Object = new System.Windows.Forms.TabControl();
            this.tabPage_Query = new System.Windows.Forms.TabPage();
            this.tabPage_Tables = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_TableList = new System.Windows.Forms.ListBox();
            this.button_Table_GenerateSql = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_ColumnList = new System.Windows.Forms.ListBox();
            this.tabPage_Procedure = new System.Windows.Forms.TabPage();
            this.listBox_ProcedureList = new System.Windows.Forms.ListBox();
            this.tabPage_QueryResult = new System.Windows.Forms.TabPage();
            this.dataGridView_QueryResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl_Object.SuspendLayout();
            this.tabPage_Query.SuspendLayout();
            this.tabPage_Tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage_Procedure.SuspendLayout();
            this.tabPage_QueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Select
            // 
            this.label_Select.AutoSize = true;
            this.label_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Select.Location = new System.Drawing.Point(4, 0);
            this.label_Select.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Select.Name = "label_Select";
            this.label_Select.Size = new System.Drawing.Size(79, 62);
            this.label_Select.TabIndex = 0;
            this.label_Select.Text = "Select";
            this.label_Select.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(527, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_Select
            // 
            this.textBox_Select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Select.Location = new System.Drawing.Point(91, 4);
            this.textBox_Select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Select.Multiline = true;
            this.textBox_Select.Name = "textBox_Select";
            this.textBox_Select.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Select.Size = new System.Drawing.Size(505, 54);
            this.textBox_Select.TabIndex = 6;
            this.textBox_Select.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_From
            // 
            this.textBox_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_From.Location = new System.Drawing.Point(91, 66);
            this.textBox_From.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_From.Multiline = true;
            this.textBox_From.Name = "textBox_From";
            this.textBox_From.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_From.Size = new System.Drawing.Size(505, 54);
            this.textBox_From.TabIndex = 7;
            this.textBox_From.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_Where
            // 
            this.textBox_Where.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Where.Location = new System.Drawing.Point(91, 128);
            this.textBox_Where.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Where.Multiline = true;
            this.textBox_Where.Name = "textBox_Where";
            this.textBox_Where.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Where.Size = new System.Drawing.Size(505, 54);
            this.textBox_Where.TabIndex = 8;
            this.textBox_Where.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_GroupBy
            // 
            this.textBox_GroupBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_GroupBy.Location = new System.Drawing.Point(91, 190);
            this.textBox_GroupBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_GroupBy.Multiline = true;
            this.textBox_GroupBy.Name = "textBox_GroupBy";
            this.textBox_GroupBy.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_GroupBy.Size = new System.Drawing.Size(505, 54);
            this.textBox_GroupBy.TabIndex = 9;
            this.textBox_GroupBy.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_OrderBy
            // 
            this.textBox_OrderBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_OrderBy.Location = new System.Drawing.Point(91, 314);
            this.textBox_OrderBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_OrderBy.Multiline = true;
            this.textBox_OrderBy.Name = "textBox_OrderBy";
            this.textBox_OrderBy.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_OrderBy.Size = new System.Drawing.Size(505, 60);
            this.textBox_OrderBy.TabIndex = 11;
            this.textBox_OrderBy.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_Having
            // 
            this.textBox_Having.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Having.Location = new System.Drawing.Point(91, 252);
            this.textBox_Having.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Having.Multiline = true;
            this.textBox_Having.Name = "textBox_Having";
            this.textBox_Having.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Having.Size = new System.Drawing.Size(505, 54);
            this.textBox_Having.TabIndex = 10;
            this.textBox_Having.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_From.Location = new System.Drawing.Point(4, 62);
            this.label_From.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(79, 62);
            this.label_From.TabIndex = 12;
            this.label_From.Text = "From";
            this.label_From.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Where
            // 
            this.label_Where.AutoSize = true;
            this.label_Where.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Where.Location = new System.Drawing.Point(4, 124);
            this.label_Where.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Where.Name = "label_Where";
            this.label_Where.Size = new System.Drawing.Size(79, 62);
            this.label_Where.TabIndex = 13;
            this.label_Where.Text = "Where";
            this.label_Where.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_GroupBy
            // 
            this.label_GroupBy.AutoSize = true;
            this.label_GroupBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_GroupBy.Location = new System.Drawing.Point(4, 186);
            this.label_GroupBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GroupBy.Name = "label_GroupBy";
            this.label_GroupBy.Size = new System.Drawing.Size(79, 62);
            this.label_GroupBy.TabIndex = 14;
            this.label_GroupBy.Text = "GroupBy";
            this.label_GroupBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Having
            // 
            this.label_Having.AutoSize = true;
            this.label_Having.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Having.Location = new System.Drawing.Point(4, 248);
            this.label_Having.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Having.Name = "label_Having";
            this.label_Having.Size = new System.Drawing.Size(79, 62);
            this.label_Having.TabIndex = 15;
            this.label_Having.Text = "Having";
            this.label_Having.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_OrderBy
            // 
            this.label_OrderBy.AutoSize = true;
            this.label_OrderBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_OrderBy.Location = new System.Drawing.Point(4, 310);
            this.label_OrderBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_OrderBy.Name = "label_OrderBy";
            this.label_OrderBy.Size = new System.Drawing.Size(79, 68);
            this.label_OrderBy.TabIndex = 16;
            this.label_OrderBy.Text = "OrderBy";
            this.label_OrderBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_QueryResult);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(600, 411);
            this.splitContainer1.SplitterDistance = 378;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_OrderBy, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Having, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_GroupBy, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Where, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_From, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Select, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Select, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_OrderBy, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_From, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Having, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_Where, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_GroupBy, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 378);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // button_QueryResult
            // 
            this.button_QueryResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_QueryResult.Location = new System.Drawing.Point(403, 0);
            this.button_QueryResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_QueryResult.Name = "button_QueryResult";
            this.button_QueryResult.Size = new System.Drawing.Size(116, 29);
            this.button_QueryResult.TabIndex = 6;
            this.button_QueryResult.Text = "QueryResult";
            this.button_QueryResult.UseVisualStyleBackColor = true;
            this.button_QueryResult.Click += new System.EventHandler(this.button_QueryResult_Click);
            // 
            // tabControl_Object
            // 
            this.tabControl_Object.Controls.Add(this.tabPage_Query);
            this.tabControl_Object.Controls.Add(this.tabPage_Tables);
            this.tabControl_Object.Controls.Add(this.tabPage_Procedure);
            this.tabControl_Object.Controls.Add(this.tabPage_QueryResult);
            this.tabControl_Object.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Object.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Object.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl_Object.Name = "tabControl_Object";
            this.tabControl_Object.SelectedIndex = 0;
            this.tabControl_Object.Size = new System.Drawing.Size(616, 448);
            this.tabControl_Object.TabIndex = 18;
            this.tabControl_Object.SelectedIndexChanged += new System.EventHandler(this.tabControl_Object_SelectedIndexChanged);
            // 
            // tabPage_Query
            // 
            this.tabPage_Query.Controls.Add(this.splitContainer1);
            this.tabPage_Query.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Query.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Query.Name = "tabPage_Query";
            this.tabPage_Query.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Query.Size = new System.Drawing.Size(608, 419);
            this.tabPage_Query.TabIndex = 0;
            this.tabPage_Query.Text = "Query";
            this.tabPage_Query.UseVisualStyleBackColor = true;
            // 
            // tabPage_Tables
            // 
            this.tabPage_Tables.Controls.Add(this.splitContainer2);
            this.tabPage_Tables.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Tables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Tables.Name = "tabPage_Tables";
            this.tabPage_Tables.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Tables.Size = new System.Drawing.Size(608, 419);
            this.tabPage_Tables.TabIndex = 1;
            this.tabPage_Tables.Text = "Tables";
            this.tabPage_Tables.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(4, 4);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.listBox_TableList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button_Table_GenerateSql);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.listBox_ColumnList);
            this.splitContainer2.Size = new System.Drawing.Size(600, 411);
            this.splitContainer2.SplitterDistance = 278;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table List";
            // 
            // listBox_TableList
            // 
            this.listBox_TableList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_TableList.FormattingEnabled = true;
            this.listBox_TableList.ItemHeight = 16;
            this.listBox_TableList.Location = new System.Drawing.Point(4, 43);
            this.listBox_TableList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_TableList.Name = "listBox_TableList";
            this.listBox_TableList.Size = new System.Drawing.Size(268, 356);
            this.listBox_TableList.TabIndex = 2;
            this.listBox_TableList.SelectedIndexChanged += new System.EventHandler(this.listBox_TableList_SelectedIndexChanged);
            // 
            // button_Table_GenerateSql
            // 
            this.button_Table_GenerateSql.Location = new System.Drawing.Point(188, 7);
            this.button_Table_GenerateSql.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Table_GenerateSql.Name = "button_Table_GenerateSql";
            this.button_Table_GenerateSql.Size = new System.Drawing.Size(120, 28);
            this.button_Table_GenerateSql.TabIndex = 5;
            this.button_Table_GenerateSql.Text = "Generate SQL";
            this.button_Table_GenerateSql.UseVisualStyleBackColor = true;
            this.button_Table_GenerateSql.Click += new System.EventHandler(this.button_Table_GenerateSql_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Column List";
            // 
            // listBox_ColumnList
            // 
            this.listBox_ColumnList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_ColumnList.FormattingEnabled = true;
            this.listBox_ColumnList.ItemHeight = 16;
            this.listBox_ColumnList.Location = new System.Drawing.Point(4, 43);
            this.listBox_ColumnList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_ColumnList.Name = "listBox_ColumnList";
            this.listBox_ColumnList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_ColumnList.Size = new System.Drawing.Size(307, 356);
            this.listBox_ColumnList.TabIndex = 3;
            // 
            // tabPage_Procedure
            // 
            this.tabPage_Procedure.Controls.Add(this.listBox_ProcedureList);
            this.tabPage_Procedure.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Procedure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Procedure.Name = "tabPage_Procedure";
            this.tabPage_Procedure.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Procedure.Size = new System.Drawing.Size(608, 419);
            this.tabPage_Procedure.TabIndex = 2;
            this.tabPage_Procedure.Text = "Procedure";
            this.tabPage_Procedure.UseVisualStyleBackColor = true;
            // 
            // listBox_ProcedureList
            // 
            this.listBox_ProcedureList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_ProcedureList.FormattingEnabled = true;
            this.listBox_ProcedureList.ItemHeight = 16;
            this.listBox_ProcedureList.Location = new System.Drawing.Point(11, 21);
            this.listBox_ProcedureList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_ProcedureList.Name = "listBox_ProcedureList";
            this.listBox_ProcedureList.Size = new System.Drawing.Size(267, 356);
            this.listBox_ProcedureList.TabIndex = 3;
            // 
            // tabPage_QueryResult
            // 
            this.tabPage_QueryResult.Controls.Add(this.dataGridView_QueryResult);
            this.tabPage_QueryResult.Location = new System.Drawing.Point(4, 25);
            this.tabPage_QueryResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_QueryResult.Name = "tabPage_QueryResult";
            this.tabPage_QueryResult.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_QueryResult.Size = new System.Drawing.Size(608, 419);
            this.tabPage_QueryResult.TabIndex = 3;
            this.tabPage_QueryResult.Text = "Query Result";
            this.tabPage_QueryResult.UseVisualStyleBackColor = true;
            // 
            // dataGridView_QueryResult
            // 
            this.dataGridView_QueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_QueryResult.Location = new System.Drawing.Point(4, 4);
            this.dataGridView_QueryResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_QueryResult.Name = "dataGridView_QueryResult";
            this.dataGridView_QueryResult.Size = new System.Drawing.Size(600, 411);
            this.dataGridView_QueryResult.TabIndex = 0;
            // 
            // frmSQLsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 448);
            this.Controls.Add(this.tabControl_Object);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSQLsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLs Editor";
            this.Shown += new System.EventHandler(this.frmSQLsEditor_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl_Object.ResumeLayout(false);
            this.tabPage_Query.ResumeLayout(false);
            this.tabPage_Tables.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage_Procedure.ResumeLayout(false);
            this.tabPage_QueryResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QueryResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Select;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Select;
        private System.Windows.Forms.TextBox textBox_From;
        private System.Windows.Forms.TextBox textBox_Where;
        private System.Windows.Forms.TextBox textBox_GroupBy;
        private System.Windows.Forms.TextBox textBox_OrderBy;
        private System.Windows.Forms.TextBox textBox_Having;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.Label label_Where;
        private System.Windows.Forms.Label label_GroupBy;
        private System.Windows.Forms.Label label_Having;
        private System.Windows.Forms.Label label_OrderBy;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl_Object;
        private System.Windows.Forms.TabPage tabPage_Query;
        private System.Windows.Forms.TabPage tabPage_Tables;
        private System.Windows.Forms.ListBox listBox_TableList;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_ColumnList;
        private System.Windows.Forms.Button button_Table_GenerateSql;
        private System.Windows.Forms.TabPage tabPage_Procedure;
        private System.Windows.Forms.ListBox listBox_ProcedureList;
        private System.Windows.Forms.Button button_QueryResult;
        private System.Windows.Forms.TabPage tabPage_QueryResult;
        private System.Windows.Forms.DataGridView dataGridView_QueryResult;
    }
}