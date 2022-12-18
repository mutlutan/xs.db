using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

namespace xs.db
{
    #region OleDb DataProvider
    public class dpOleDb : DataProvider
    {
        #region Değiştirilen Propertiler
        [Browsable(true)]
        [DefaultValue("")]
        [SettingsBindable(true)]
        [RefreshProperties(RefreshProperties.All)]
        [Editor("Microsoft.VSDesigner.Data.ADO.Design.OleDbConnectionStringEditor, Microsoft.VSDesigner, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new string ConnectionString
        {
            get { return base.ConnectionString; }
            set { base.ConnectionString = value; }
        }

        #endregion

        public override void ReadSchema(ref DataTable dt, string SqlText)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(SqlText, this.ConnectionString);
            da.FillSchema(dt, SchemaType.Source);
        }

        public override void ReadData(ref DataTable dt, string SqlText)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(SqlText, this.ConnectionString);
            da.Fill(dt);
        }

        public override void SaveChanges(ref DataRow dr, string SqlText, ConflictOption _ConflictOption)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(SqlText, this.ConnectionString);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            cb.SetAllValues = false; // sadece değiştirilmiş alanlar için update cümlesi oluşturulacak
            cb.ConflictOption = _ConflictOption; // Çakışma Ayarlayıcısı  

            DataRow[] drArray = new DataRow[1];
            drArray[0] = dr;
            da.Update(drArray);
        }

        public override void ExecuteNonQuery(string SqlText)
        {
            using (OleDbCommand Command = new OleDbCommand(SqlText, new OleDbConnection(this.ConnectionString)))
            {
                Command.Connection.Open();
                Command.ExecuteNonQuery();
                Command.Connection.Close();
            }
        }

        public override object ExecuteScalar(string SqlText)
        {
            object rV = null;
            using (OleDbCommand Command = new OleDbCommand(SqlText, new OleDbConnection(this.ConnectionString)))
            {
                Command.Connection.Open();
                rV = Command.ExecuteScalar();
                Command.Connection.Close();
            }
            return rV;
        }

        public override void ExecuteNonQueryWithTransection(List<string> SqlTextList)
        {
            OleDbCommand Command = new OleDbCommand("", new OleDbConnection(this.ConnectionString));
            Command.Connection.Open();
            OleDbTransaction Transaction = Command.Connection.BeginTransaction();

            try
            {
                foreach (string S in SqlTextList)
                {
                    Command.CommandText = S;
                    Command.ExecuteNonQuery();
                }
                Transaction.Commit();
                Command.Connection.Close();
            }
            catch (Exception ex)
            {
                Transaction.Rollback();
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                Command.Connection.Close();
                Command.Dispose();
            }
        }

        public override string SqlConvertFetching(string SqlText, int StartRecord, int FetchSize)
        {
            return SqlText;
        }

        public override List<string> GetTableList()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetColumnList(string TableName)
        {
            throw new NotImplementedException();
        }

        public override List<string> GetProcedureList()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetFunctionList()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetViewList()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetSequenceList()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

}
