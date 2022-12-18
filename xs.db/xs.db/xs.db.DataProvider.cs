using System;
using System.ComponentModel;
using System.Data;

using System.Reflection;
using System.Drawing;
using System.Collections.Generic;

namespace xs.db
{
    public class AbstractControlDescriptionProvider<TAbstract, TBase> : TypeDescriptionProvider
    {
        public AbstractControlDescriptionProvider()
            : base(TypeDescriptor.GetProvider(typeof(TAbstract)))
        {
        }

        public override Type GetReflectionType(Type objectType, object instance)
        {
            if (objectType == typeof(TAbstract))
                return typeof(TBase);

            return base.GetReflectionType(objectType, instance);
        }

        public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
        {
            if (objectType == typeof(TAbstract))
                objectType = typeof(TBase);

            return base.CreateInstance(provider, objectType, argTypes, args);
        }
    }

    #region abstract DataProvider
    [ToolboxItem(false)]
    [TypeConverter(typeof(DataProviderTypeConverter))] //eski 
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<DataProvider, Component>))] //yeni
    public abstract class DataProvider : Component
    {
        public string ConnectionString;
        public string CustomDll;
        public abstract void ReadSchema(ref DataTable dt, string SqlText);
        public abstract void ReadData(ref DataTable dt, string SqlText);
        public abstract void SaveChanges(ref DataRow dr, string SqlText, ConflictOption _ConflictOption);

        public abstract void ExecuteNonQuery(string SqlText);
        public abstract object ExecuteScalar(string SqlText);
        public abstract void ExecuteNonQueryWithTransection(List<string> SqlTextList);

        public abstract string SqlConvertFetching(string SqlText, int StartRecord, int FetchSize);

        public abstract List<string> GetTableList();
        public abstract List<string> GetColumnList(string TableName);
        public abstract List<string> GetProcedureList();
        public abstract List<string> GetFunctionList();
        public abstract List<string> GetViewList();
        public abstract List<string> GetSequenceList();

        
        public DataProvider()
        {
            ConnectionString = "";
            CustomDll = "";
        }

        ~DataProvider()
        {
            this.Dispose(true);
        }        
    }

    #endregion

    #region DataProvider TypeConverter
    public class DataProviderTypeConverter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            DataProvider DataProvider1 = (DataProvider)value;
            return DataProvider1;
        }
    }
    #endregion


}
