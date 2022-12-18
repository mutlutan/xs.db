using System;
using System.ComponentModel;
using System.Data;

namespace xs.db
{
    #region DataOptions
    [ToolboxItem(false)]
    [DesignTimeVisible(false)]
    [TypeConverter(typeof(DataOptionsTypeConverter))]
    public class DataOptions : Component
    {
        private Boolean _AutoRecordRefresh;
        [DefaultValue(true)]
        public Boolean AutoRecordRefresh
        {
            get { return _AutoRecordRefresh; }
            set { _AutoRecordRefresh = value; }
        }

        private Boolean _Fetching;
        [DefaultValue(true)]
        public Boolean Fetching
        {
            get { return _Fetching; }
            set { _Fetching = value; }
        }

        private int _FetchSize;
        [DefaultValue(25)]
        public int FetchSize
        {
            get { return _FetchSize; }
            set { _FetchSize = value; }
        }

        private int _Fetched;
        [DefaultValue(0)]
        public int Fetched
        {
            get { return _Fetched; }
            set { _Fetched = value; }
        }
        
        private Boolean _Deleteconfirmation;
        [DefaultValue(true)]
        public Boolean Deleteconfirmation
        {
            get { return _Deleteconfirmation; }
            set { _Deleteconfirmation = value; }
        }

        private string _DeleteconfirmationMessage;
        [DefaultValue("Do you want to delete this record?")]
        public string DeleteconfirmationMessage
        {
            get { return _DeleteconfirmationMessage; }
            set { _DeleteconfirmationMessage = value; }
        }

        public DataOptions()
        {
            //this._FillSchema = true;
            this._AutoRecordRefresh = true;
            this.Fetching = true;
            this.FetchSize = 25;
            this._Fetched = 0;
            this._Deleteconfirmation = true;
            this._DeleteconfirmationMessage = "Do you want to delete this record?";
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        ~DataOptions()
        {
            this.Dispose(true);
        }

    }
    #endregion

    #region DataOptions TypeConverter
    public class DataOptionsTypeConverter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            return null;
        }
    }

    #endregion
}
