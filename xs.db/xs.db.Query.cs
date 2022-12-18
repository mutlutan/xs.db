using System;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Reflection;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.Windows.Forms;
using System.Collections.Generic;

namespace xs.db
{
    public enum DatabaseType { OleDb, SqlClient, CustomDB };  

    #region xsQuery
    [ToolboxItem(true)]
    [DesignTimeVisible(true)]
    [ToolboxBitmap(typeof(xsQuery), "Resources.xsQuery")]
    [Description("Query")]
    [CategoryAttribute("xsData")]
    [Designer(typeof(xsQueryDesigner))]
    public class xsQuery : DataTable
    {
        #region Değiştirilen Propertiler
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new DataColumnCollection Columns
        {
            get { return base.Columns; } 
        }

        #endregion

        #region Gizlenen Propertiler        
        [Browsable(false)]
        public new bool CaseSensitive
        {
            get { return base.CaseSensitive; }
            set { base.CaseSensitive = value; }
        }

        [Browsable(false)]
        public new object Constraints
        {
            get { return base.Constraints; }
        }

        [Browsable(false)]
        public new string DisplayExpression
        {
            get { return base.DisplayExpression; }
            set { base.DisplayExpression = value; }
        }

        [Browsable(false)]
        public new int MinimumCapacity
        {
            get { return base.MinimumCapacity; }
            set { base.MinimumCapacity = value; }
        }

        [Browsable(false)]
        public new string Namespace
        {
            get { return base.Namespace; }
            set { base.Namespace = value; }
        }

        [Browsable(false)]
        public new string Prefix
        {
            get { return base.Prefix; }
            set { base.Prefix = value; }
        }

        [Browsable(false)]
        public new DataColumn[] PrimaryKey
        {
            get { return base.PrimaryKey; }
            set { base.PrimaryKey = value; }
        }

        //[Browsable(false)]
        //public new string TableName
        //{
        //    get { return base.TableName; }
        //    set { base.TableName = value; }
        //}

        #endregion Gizlenen Propertiler

        #region Eklenen Gizli Propertiler

        #endregion

        #region Eklenen Propertiler
        public string Version
        {
            get 
            {
                AssemblyName assemblyName = new AssemblyName(Assembly.GetExecutingAssembly().ToString());
                return assemblyName.Version.ToString(3); // buradaki 3 ile ilk 3 numarayı alıyoruz.                  
            }
        }

        private DatabaseType _DatabaseType = DatabaseType.SqlClient;
        [DefaultValue(DatabaseType.SqlClient)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DatabaseType DatabaseType
        {
            get { return _DatabaseType; }
            set 
            {
                if (_DatabaseType != value)
                {
                    _DataProvider.Dispose();
                    _DatabaseType = value;
                    if (_DatabaseType == db.DatabaseType.OleDb)
                    {
                        _DataProvider = new dpOleDb();
                    }
                    else if (_DatabaseType == db.DatabaseType.SqlClient)
                    {
                        _DataProvider = new dpSqlClient();
                    }
                    else if (_DatabaseType == db.DatabaseType.CustomDB)
                    {
                        _DataProvider = new dpCustom();
                    }
                    else
                    {
                        _DataProvider = new dpSqlClient();
                    }                    
                }
            }
        }


        private DataProvider _DataProvider = new dpSqlClient();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataProvider DataProvider
        {
            get { return _DataProvider; }
            set { _DataProvider = value; }
        }

        private xsSQLs _Command;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public xsSQLs Command
        {
            get 
            {
                _Command.Query = this;
                return _Command; 
            }
            set 
            {
                _Command.Query = this;
                _Command = value;
            }
        }

        private ConflictOption _ConflictOption = ConflictOption.OverwriteChanges;
        [DefaultValue(ConflictOption.OverwriteChanges)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ConflictOption ConflictOption
        {
            get { return _ConflictOption; }
            set { _ConflictOption = value; }
        }


        private DataOptions _DataOptions = new DataOptions();
        [Category("Data Options")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DataOptions DataOptions
        {
            get { return _DataOptions; }
            set { _DataOptions = value;}
        }

        // read data anında true oluyor
        private Boolean _IsDataReading;
        private Boolean _IsDataRemoving;

        #endregion

        #region Gizlenen Eventler
        // bu eventlar aşağıda kullanıldığından ve componetin kullanımında sorun çıkartacağından gizleniyor
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new event DataRowChangeEventHandler RowChanged 
        {
            add { base.RowChanged += value; }
            remove { base.RowChanged -= value; }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public new event DataRowChangeEventHandler RowDeleted
        {
            add { base.RowDeleted += value; }
            remove { base.RowDeleted -= value; }
        }

        #endregion

        #region Eklenen Eventler

        //OnRowChanged 
        public delegate void OnRowChangedEvent(object sender, ref DataRowChangeEventArgs e);
        public new event OnRowChangedEvent OnRowChanged;

        //OnRowDeleted
        public delegate void OnRowDeletedEvent(object sender, ref DataRowChangeEventArgs e);
        public new event OnRowDeletedEvent OnRowDeleted;

        #endregion

        // fonksiyonlar
        public xsQuery()
        {
            _Command = new xsSQLs();
            this._Command.Query = this;
            RegisterAllEvent();            
        }

        ~xsQuery()
        {
            this.Dispose(true);
        }

        // fonksiyonlar ------------------

        void RegisterAllEvent()
        {
            this.RowChanged += new DataRowChangeEventHandler(xsQuery_RowChanged);
            this.RowDeleted += new DataRowChangeEventHandler(xsQuery_RowDeleted);
        }

        void UnRegisterAllEvent()
        {
            this.RowChanged -= new DataRowChangeEventHandler(xsQuery_RowChanged);
            this.RowDeleted -= new DataRowChangeEventHandler(xsQuery_RowDeleted);
        }

        

        void xsQuery_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (!this._IsDataReading)
            {
                UnRegisterAllEvent();
                try
                {
                    if (OnRowChanged != null)
                    {
                        OnRowChanged(sender, ref e);
                    }
                    e.Row.RowError = "";
                    DataRow drU = e.Row;
                    this.SaveChanges(ref drU, true);
                }
                catch (Exception ex)
                {
                    e.Row.RowError = ex.Message;
                    e.Row.RejectChanges();
                    throw new Exception(ex.Message, ex);
                }

                RegisterAllEvent();
            }             
        }

        void xsQuery_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            if (!this._IsDataReading)
            {
                UnRegisterAllEvent();
                try
                {
                    Boolean isDelete = false;
                    if (this.DataOptions.Deleteconfirmation)
                    {
                        if (MessageBox.Show(this.DataOptions.DeleteconfirmationMessage, "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            isDelete = true;
                        }
                    }
                    else
                    {
                        isDelete = true;
                    }

                    if (isDelete)
                    {
                        if (!this._IsDataReading)
                        {
                            if (OnRowDeleted != null)
                            {
                                OnRowDeleted(sender, ref e);
                            }

                            DataRow drU = e.Row;
                            this.SaveChanges(ref drU, false);
                        }
                    }
                    else
                    {
                        e.Row.RejectChanges();
                    }
                }
                catch (Exception ex)
                {
                    e.Row.RowError = ex.Message;
                    e.Row.RejectChanges();
                    throw new Exception(ex.Message, ex);
                }

                RegisterAllEvent();
            }
        }      

        public Boolean ReadSchema()
        {
            Boolean rV = false;
            DataTable dt = this;
            try
            {
                this._DataProvider.ReadSchema(ref dt, this.Command.SQLText);

                if (DesignMode)
                {
                    foreach (DataColumn dc in this.Columns)
                    {
                        this.Container.Add(dc, this.TableName + "_" + dc.ColumnName);
                    }
                }
                rV = true;

            }
            catch(Exception ex)
            {
                if (DesignMode)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                else
                {
                    throw new Exception(ex.Message, ex);
                }
            }
            
            return rV;
        }

        public Boolean RemoveSchema()
        {
            Boolean rV = false;

            try
            {
                foreach (DataColumn dc in this.Columns)
                {
                    this.Container.Remove(dc);
                }
                this.PrimaryKey = null;
                this.Columns.Clear();
                rV = true;
            }
            catch (Exception ex)
            {
                if (DesignMode)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message, "Exception");
                } 
            }

            return rV;
        }

        public Boolean Close()
        {
            Boolean rV = false;

            this._IsDataRemoving = true;

            this.Rows.Clear();
            this.AcceptChanges();
            this.DataOptions.Fetched = 0;

            this._IsDataRemoving = false;

            rV = true;
            return rV;
        }

        public Boolean Open()
        {
            Boolean rV = false;
            this.Close();
            Application.DoEvents();
            rV = this.ReadData();
            return rV;
        }

        public Boolean ReadData()
        {
            Boolean rV = false;
            if (!this._IsDataRemoving)
            {
                this._IsDataReading = true;                
                DataTable dt = this;
                dt.AcceptChanges();

                if (this.DataOptions.Fetching)
                {
                    this._DataProvider.ReadData(ref dt, this._DataProvider.SqlConvertFetching(this.Command.SQLText, this.DataOptions.Fetched, this.DataOptions.FetchSize));
                    this.DataOptions.Fetched += this.DataOptions.FetchSize;
                    rV = true;
                }
                else
                {
                    this._DataProvider.ReadData(ref dt, this.Command.SQLText);
                    rV = true;
                }

                this._IsDataReading = false;
            }
            return rV;
        }

        private Boolean SaveChanges(ref DataRow drU, Boolean _Changed)
        {
            Boolean rV = false;
            
            this._DataProvider.SaveChanges(ref drU, this.Command.SQLText, this._ConflictOption);
            if (_Changed) //eğer row silinmediyse bu kod hatasız çalışır, silinince row  bulunmadığından hata alır
            {                
                rV = true;
                // burada record refresh codunu yazabilirsin....
                if (this.DataOptions.AutoRecordRefresh)
                {
                    rV = this.RecordRefreshBase(ref drU);
                }
                
                drU.AcceptChanges();
            }

            return rV;
        }


        public Boolean ExecuteNonQuery(string _SQLText)
        {
            Boolean rV = false;
            this.DataProvider.ExecuteNonQuery(_SQLText);
            rV = true;
           
            return rV;
        }

        public object ExecuteScalar(string _SQLText)
        {
            object rV = this.DataProvider.ExecuteScalar(_SQLText);
            return rV;
        }

        public Boolean ExecuteNonQueryWithTransection(List<string> SqlTextList)
        {
            Boolean rV = false;
            this.DataProvider.ExecuteNonQueryWithTransection(SqlTextList);
            rV = true;

            return rV;
        }


        public int RecordCount()
        {
            int rV = 0;
            DataTable dt = new DataTable("xCountTable");
            this._DataProvider.ReadData(ref dt, "Select count(*) from (" + this.Command.SQLText_NoOrderBy + ") as xCountTable");
            rV = Convert.ToInt32(dt.Rows[0][0]);
            return rV;
        }

        public Boolean RecordRefresh(ref DataRow _dr)
        {
            Boolean rV = false;
            UnRegisterAllEvent();
            rV = RecordRefreshBase(ref _dr);
            _dr.AcceptChanges();
            RegisterAllEvent();
            return rV;
        }

        private Boolean RecordRefreshBase(ref DataRow _dr)
        {
            Boolean rV = false;
            
            if (!this._IsDataReading)
            {
                string _ColumnName = "";
                foreach (DataColumn dc in this.Columns)
                {                    
                    if (dc.Unique)
                    {
                        _ColumnName = dc.ColumnName;
                        break;
                    }
                }

                if (_ColumnName.Length > 0)
                {
                    DataTable dt = new DataTable();
                    this._DataProvider.ReadData(ref dt, this.Command.Select + " " + this.Command.From + " where " + _ColumnName + "=" + _dr[_ColumnName].ToString());                                        

                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (dc.ColumnName != _ColumnName) // primery key alanı hariç  güncellenecek.
                        {
                            if (!_dr[dc.ColumnName].Equals(dt.Rows[0][dc.ColumnName])) // içeriği değişen update edilsin
                            {
                                if (!this.Columns[dc.ColumnName].ReadOnly) // ReadOnly olmayan alanlar refresh ediliyor.
                                {
                                    _dr[dc.ColumnName] = dt.Rows[0][dc.ColumnName];
                                }
                                else //ReadOnly alanlar refresh ediliyor.
                                {
                                    this.Columns[dc.ColumnName].ReadOnly = false;
                                    _dr[dc.ColumnName] = dt.Rows[0][dc.ColumnName];
                                    this.Columns[dc.ColumnName].ReadOnly = true;
                                }
                            }
                        }

                        rV = true;
                    }                   
                }

               
                
            }
            return rV;
        }

        
    }
    #endregion



}
