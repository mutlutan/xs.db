namespace xsdb_test
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.xsBindingSource1 = new xs.db.xsBindingSource();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xsQuery1 = new xs.db.xsQuery();
            this.xsQuery1_IND = new System.Data.DataColumn();
            this.xsQuery1_KODU = new System.Data.DataColumn();
            this.xsQuery1_ADI = new System.Data.DataColumn();
            this.ıNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kODUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xsQuery1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Read Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "endedit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(717, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(129, 23);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 9;
            this.button5.Text = "Open";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // xsBindingSource1
            // 
            this.xsBindingSource1.DataSource = this.xsQuery1;
            this.xsBindingSource1.Position = 0;
            this.xsBindingSource1.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.xsBindingSource1_DataError);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıNDDataGridViewTextBoxColumn,
            this.kODUDataGridViewTextBoxColumn,
            this.aDIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.xsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(33, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 279);
            this.dataGridView1.TabIndex = 10;
            // 
            // xsQuery1
            // 
            this.xsQuery1.Columns.AddRange(new System.Data.DataColumn[] {
            this.xsQuery1_IND,
            this.xsQuery1_KODU,
            this.xsQuery1_ADI});
            this.xsQuery1.Command.From = "From TBLSERI2";
            this.xsQuery1.Command.GroupBy = "";
            this.xsQuery1.Command.Having = "";
            this.xsQuery1.Command.OrderBy = "order by 1";
            this.xsQuery1.Command.Select = "Select *";
            this.xsQuery1.Command.Where = "";
            // 
            // 
            // 
            this.xsQuery1.DataOptions.Fetched = 25;
            // 
            // 
            // 
            this.xsQuery1.DataProvider.ConnectionString = "Data Source=.;Initial Catalog=VEGADB;Integrated Security=true;";
            this.xsQuery1.Namespace = "";
            this.xsQuery1.PrimaryKey = new System.Data.DataColumn[] {
        this.xsQuery1_IND};
            this.xsQuery1.TableName = "xsQuery1";
            // 
            // xsQuery1_IND
            // 
            this.xsQuery1_IND.AllowDBNull = false;
            this.xsQuery1_IND.AutoIncrement = true;
            this.xsQuery1_IND.ColumnName = "IND";
            this.xsQuery1_IND.DataType = typeof(int);
            this.xsQuery1_IND.ReadOnly = true;
            // 
            // xsQuery1_KODU
            // 
            this.xsQuery1_KODU.ColumnName = "KODU";
            this.xsQuery1_KODU.MaxLength = 10;
            // 
            // xsQuery1_ADI
            // 
            this.xsQuery1_ADI.ColumnName = "ADI";
            this.xsQuery1_ADI.MaxLength = 50;
            // 
            // ıNDDataGridViewTextBoxColumn
            // 
            this.ıNDDataGridViewTextBoxColumn.DataPropertyName = "IND";
            this.ıNDDataGridViewTextBoxColumn.HeaderText = "IND";
            this.ıNDDataGridViewTextBoxColumn.Name = "ıNDDataGridViewTextBoxColumn";
            this.ıNDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kODUDataGridViewTextBoxColumn
            // 
            this.kODUDataGridViewTextBoxColumn.DataPropertyName = "KODU";
            this.kODUDataGridViewTextBoxColumn.HeaderText = "KODU";
            this.kODUDataGridViewTextBoxColumn.Name = "kODUDataGridViewTextBoxColumn";
            // 
            // aDIDataGridViewTextBoxColumn
            // 
            this.aDIDataGridViewTextBoxColumn.DataPropertyName = "ADI";
            this.aDIDataGridViewTextBoxColumn.HeaderText = "ADI";
            this.aDIDataGridViewTextBoxColumn.Name = "aDIDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xsQuery1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private xs.db.xsBindingSource xsBindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private xs.db.xsQuery xsQuery1;
        private System.Data.DataColumn xsQuery1_IND;
        private System.Data.DataColumn xsQuery1_KODU;
        private System.Data.DataColumn xsQuery1_ADI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDIDataGridViewTextBoxColumn;
    }
}

