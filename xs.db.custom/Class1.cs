using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibrary1
{
    public class Class1 : xs.db.DataProvider
    {
        public override void ReadSchema(ref DataTable dt, string SqlText)
        {
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(SqlText, this.ConnectionString);
            da.FillSchema(dt, SchemaType.Source);
        }

        public override void ReadData(ref DataTable dt, string SqlText)
        {
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(SqlText, this.ConnectionString);
            da.Fill(dt);
        }

        public override void SaveChanges(ref DataRow dr, string SqlText, ConflictOption _ConflictOption)
        {
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(SqlText, this.ConnectionString);
            System.Data.SqlClient.SqlCommandBuilder cb = new System.Data.SqlClient.SqlCommandBuilder(da);
            cb.SetAllValues = false; // sadece değiştirilmiş alanlar için update cümlesi oluşturulacak
            cb.ConflictOption = _ConflictOption; // Çakışma Ayarlayıcısı  

            DataRow[] drArray = new DataRow[1];
            drArray[0] = dr;
            da.Update(drArray);
        }

        public override void ExecuteNonQuery(string SqlText)
        {
            throw new NotImplementedException();
        }

        public override object ExecuteScalar(string SqlText)
        {
            throw new NotImplementedException();
        }

        public override void ExecuteNonQueryWithTransection(List<string> SqlTextList)
        {
            throw new NotImplementedException();
        }

        public override string SqlConvertFetching(string SqlText, int StartRecord, int FetchSize)
        {
            throw new NotImplementedException();
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
}
