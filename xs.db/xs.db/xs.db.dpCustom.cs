using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Data;
using System.Drawing.Design;

namespace xs.db
{
    #region Custom DataProvider
    public class dpCustom : DataProvider
    {
        #region Değiştirilen Propertiler
        [Browsable(true)]
        [DefaultValue("")]
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(UITypeEditor))]
        public new string ConnectionString
        {
            get { return base.ConnectionString; }
            set { base.ConnectionString = value; }
        }

        [Browsable(true)]
        [DefaultValue("")]
        [Editor(typeof(System.Windows.Forms.Design.FileNameEditor),typeof(UITypeEditor))]        
        public new string CustomDll
        {
            get { return base.CustomDll; }
            set { base.CustomDll = value; }
        }

        #endregion

        private DataProvider getDP(string _ConnectionString)
        {

            System.Reflection.Assembly asm = System.Reflection.Assembly.LoadFile(CustomDll);

            object obj = asm.CreateInstance("ClassLibrary1.class1", true); // load edilen dll içindeki namespace adı ve class adını istiyor

            (obj as DataProvider).ConnectionString = _ConnectionString;

            return (DataProvider)obj;
        }


        public override void ReadSchema(ref DataTable dt, string SqlText)
        {
            getDP(this.ConnectionString).ReadSchema(ref dt, SqlText);
        }

        public override void ReadData(ref DataTable dt, string SqlText)
        {
            getDP(this.ConnectionString).ReadData(ref dt, SqlText);
        }

        public override void SaveChanges(ref DataRow dr, string SqlText, ConflictOption _ConflictOption)
        {
            getDP(this.ConnectionString).SaveChanges(ref dr, SqlText, _ConflictOption);
        }

        public override void ExecuteNonQuery(string SqlText)
        {
            getDP(this.ConnectionString).ExecuteNonQuery(SqlText);
        }

        public override object ExecuteScalar(string SqlText)
        {
            return getDP(this.ConnectionString).ExecuteScalar(SqlText);
        }

        public override void ExecuteNonQueryWithTransection(List<string> SqlTextList)
        {
            getDP(this.ConnectionString).ExecuteNonQueryWithTransection(SqlTextList);
        }

        public override string SqlConvertFetching(string SqlText, int StartRecord, int FetchSize)
        {
            return getDP(this.ConnectionString).SqlConvertFetching(SqlText, StartRecord, FetchSize);
        }

        public override List<string> GetTableList()
        {
            return getDP(this.ConnectionString).GetTableList();            
        }

        public override List<string> GetColumnList(string TableName)
        {
            return getDP(this.ConnectionString).GetColumnList(TableName);
        }

        public override List<string> GetProcedureList()
        {
            return getDP(this.ConnectionString).GetProcedureList();
        }

        public override List<string> GetFunctionList()
        {
            return getDP(this.ConnectionString).GetFunctionList();
        }

        public override List<string> GetViewList()
        {
            return getDP(this.ConnectionString).GetViewList();
        }

        public override List<string> GetSequenceList()
        {
            return getDP(this.ConnectionString).GetSequenceList();
        }
    }
    #endregion
}
