using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace xs.db
{
    public partial class frmSQLsEditor : Form
    {
        IWindowsFormsEditorService EditorService1 = null;
        private xsSQLs _SQLs;
        public xsSQLs SQLs
        {
            get 
            {
                _SQLs.Select = textBox_Select.Text;
                _SQLs.From = textBox_From.Text;
                _SQLs.Where = textBox_Where.Text;
                _SQLs.GroupBy = textBox_GroupBy.Text;
                _SQLs.Having = textBox_Having.Text;
                _SQLs.OrderBy = textBox_OrderBy.Text;
                return _SQLs; 
            }
            
            set 
            {             
                _SQLs = value;
                textBox_Select.Text = _SQLs.Select;
                textBox_From.Text = _SQLs.From;
                textBox_Where.Text = _SQLs.Where;
                textBox_GroupBy.Text = _SQLs.GroupBy;
                textBox_Having.Text = _SQLs.Having;
                textBox_OrderBy.Text = _SQLs.OrderBy;
            }
        }

        public frmSQLsEditor(IWindowsFormsEditorService _EditorService)
        {
            InitializeComponent();
            this.EditorService1 = _EditorService;
        }

        private void frmSQLsEditor_Shown(object sender, EventArgs e)
        {                                                                 
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Select
                if (textBox_Select.Text.Trim().Length > 0)
                {
                    label_Select.Font = new Font(label_Select.Font, FontStyle.Bold);
                }
                else
                {
                    label_Select.Font = new Font(label_Select.Font, FontStyle.Regular);
                }

                //From
                if (textBox_From.Text.Trim().Length > 0)
                {
                    label_From.Font = new Font(label_From.Font, FontStyle.Bold);
                }
                else
                {
                    label_From.Font = new Font(label_From.Font, FontStyle.Regular);
                }

                //Where
                if (textBox_Where.Text.Trim().Length > 0)
                {
                    label_Where.Font = new Font(label_Where.Font, FontStyle.Bold);
                }
                else
                {
                    label_Where.Font = new Font(label_Where.Font, FontStyle.Regular);
                }

                //GroupBy
                if (textBox_GroupBy.Text.Trim().Length > 0)
                {
                    label_GroupBy.Font = new Font(label_GroupBy.Font, FontStyle.Bold);
                }
                else
                {
                    label_GroupBy.Font = new Font(label_GroupBy.Font, FontStyle.Regular);
                }

                //Having
                if (textBox_Having.Text.Trim().Length > 0)
                {
                    label_Having.Font = new Font(label_Having.Font, FontStyle.Bold);
                }
                else
                {
                    label_Having.Font = new Font(label_Having.Font, FontStyle.Regular);
                }

                //OrderBy
                if (textBox_OrderBy.Text.Trim().Length > 0)
                {
                    label_OrderBy.Font = new Font(label_OrderBy.Font, FontStyle.Bold);
                }
                else
                {
                    label_OrderBy.Font = new Font(label_OrderBy.Font, FontStyle.Regular);
                }

            }
            catch { }

        }

        private void button_QueryResult_Click(object sender, EventArgs e)
        {                                   
            try
            {
                DataTable dt = new DataTable("Table1");
                string _S = textBox_Select.Text + " " + textBox_From.Text + " " + textBox_Where.Text + " " + textBox_GroupBy.Text + " " + textBox_Having.Text + " " + textBox_OrderBy.Text;
                _SQLs.Query.DataProvider.ReadData(ref dt, _S);
                dataGridView_QueryResult.ReadOnly = true;
                dataGridView_QueryResult.DataSource = dt;
                tabControl_Object.SelectedTab = tabPage_QueryResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void tabControl_Object_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Select Table
                if (tabControl_Object.SelectedTab == tabPage_Tables)
                {
                    if (listBox_TableList.SelectedIndex == -1)
                    {
                        listBox_TableList.Items.Clear();
                        foreach (string s in _SQLs.Query.DataProvider.GetTableList())
                        {
                            listBox_TableList.Items.Add(s);
                        }
                    }
                }

                //Select Procedure
                if (tabControl_Object.SelectedTab == tabPage_Procedure)
                {
                    foreach (string s in _SQLs.Query.DataProvider.GetProcedureList())
                    {
                        listBox_ProcedureList.Items.Clear();
                        listBox_ProcedureList.Items.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void listBox_TableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBox_ColumnList.Items.Clear();
                listBox_ColumnList.Items.Add("*");
                foreach (string s in _SQLs.Query.DataProvider.GetColumnList(listBox_TableList.SelectedItem.ToString()))
                {
                    listBox_ColumnList.Items.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Table_GenerateSql_Click(object sender, EventArgs e)
        {
            if (listBox_ColumnList.SelectedItems.Count > 0)
            {
                string _S = "";
                textBox_Select.Text = "";
                foreach (string item in listBox_ColumnList.SelectedItems)
                {
                    if (_S.Length > 0) _S += ", ";
                    _S += item.ToString();
                }

                textBox_Select.Text = "Select " + _S;
                textBox_From.Text = "From " + listBox_TableList.Text;

                tabControl_Object.SelectedTab = tabPage_Query;
            }

        }





    }
}
