using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace xs.db
{

    #region Designer - SQLsEditor
    public class xsSQLsEditor : UITypeEditor
    {        
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if (context != null) return UITypeEditorEditStyle.Modal;
            return base.GetEditStyle(context);
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            if ((context != null) && (provider != null))
            {
                // Access the Property Browser's UI display service
                IWindowsFormsEditorService EditorService1 = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

                if (EditorService1 != null)
                {
                    // Create an instance of the UI editor control
                    frmSQLsEditor frmSQLsEditor1 = new frmSQLsEditor(EditorService1);
                    

                    // Pass the UI editor control the current property value
                    frmSQLsEditor1.SQLs = (xsSQLs)value;
                    

                    // Display the UI editor control
                    if (EditorService1.ShowDialog(frmSQLsEditor1) == DialogResult.OK)
                    {
                        // Return the new property value from the UI editor form 
                        xsSQLs xsSQLs1 = new xsSQLs();
                        xsSQLs1.Select = frmSQLsEditor1.SQLs.Select;
                        xsSQLs1.From = frmSQLsEditor1.SQLs.From;
                        xsSQLs1.Where = frmSQLsEditor1.SQLs.Where;
                        xsSQLs1.GroupBy = frmSQLsEditor1.SQLs.GroupBy;
                        xsSQLs1.Having = frmSQLsEditor1.SQLs.Having;
                        xsSQLs1.OrderBy = frmSQLsEditor1.SQLs.OrderBy;
                        return xsSQLs1;
                    }
                    //--------------------------------------------------------------------
                    
                }
            }
            return base.EditValue(context, provider, value);
        }

        ~xsSQLsEditor()
        {
            GC.SuppressFinalize(this);
        }

    }

    #endregion


    #region xsSQLs
    [ToolboxItem(false)]
    [TypeConverter(typeof(xsSQLsTypeConverter))]
    [Editor(typeof(xsSQLsEditor), typeof(UITypeEditor))]
    public class xsSQLs :IDisposable
    {
        private xsQuery _Query;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public xsQuery Query
        {
            get { return _Query; }
            set { _Query = value; }
        }

        private string _Select = "";
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(UITypeEditor))]
        public string Select
        {
            get { return _Select; }
            set { _Select = value; }
        }

        private string _From = "";
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(UITypeEditor))]
        public string From
        {
            get { return _From; }
            set { _From = value; }
        }

        private string _Where = "";
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(UITypeEditor))]
        public string Where
        {
            get { return _Where; }
            set { _Where = value; }
        }

        private string _GroupBy = "";
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(UITypeEditor))]
        public string GroupBy
        {
            get { return _GroupBy; }
            set { _GroupBy = value; }
        }

        private string _Having = "";
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(UITypeEditor))]
        public string Having
        {
            get { return _Having; }
            set { _Having = value; }
        }

        private string _OrderBy = "";
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(UITypeEditor))]
        public string OrderBy
        {
            get { return _OrderBy; }
            set { _OrderBy = value; }
        }

        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(UITypeEditor))]
        public string SQLText
        {
            get
            {
                return _Select + " " + _From + " " + _Where + " " + _GroupBy + " " + _Having + " " + _OrderBy;
            }
        }

        [Browsable(false)]
        public string SQLText_NoOrderBy
        {
            get
            {
                return _Select + " " + _From + " " + _Where + " " + _GroupBy + " " + _Having;
            }
        }


        public xsSQLs()
        {
            _Select = "Select *";
            _From = "From tb";
        }

        ~xsSQLs()
        {
            Dispose();
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
    #endregion

    #region xsSQLsTypeConverter
    public class xsSQLsTypeConverter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            xsSQLs xsSQLs1 = (xsSQLs)value;
            return xsSQLs1.Select + ";" + xsSQLs1.From + ";" + xsSQLs1.Where + ";" + xsSQLs1.GroupBy + ";" + xsSQLs1.Having + ";" + xsSQLs1.OrderBy;
        }


        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return true;
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            xsSQLs xsSQLs1 = new xsSQLs();
            string[] sArray= value.ToString().Split(';');
            xsSQLs1.Select = sArray[0];
            xsSQLs1.From = sArray[1];
            xsSQLs1.Where = sArray[2];
            xsSQLs1.GroupBy = sArray[3];
            xsSQLs1.Having = sArray[4];
            xsSQLs1.OrderBy = sArray[5];            
            return xsSQLs1;
        }
    }
    #endregion
}
