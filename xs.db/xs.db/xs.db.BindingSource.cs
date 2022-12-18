using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xs.db
{
    #region xsBS

    [ToolboxItem(true)]
    [DesignTimeVisible(true)]
    [ToolboxBitmap(typeof(xsBindingSource), "Resources.xsBindingSource")]
    [Description("BindingSource")]
    [CategoryAttribute("xsData")]
    public class xsBindingSource : BindingSource
    {
        #region Değiştirilen Propertiler
        [Browsable(true)]
        public new int Count
        {
            get { return base.Count; }
        }
        [Browsable(true)]
        public new int Position
        {
            get { return base.Position; }
            set { base.Position = value; }
        }

        #endregion



        public xsBindingSource()
        {
            this.PositionChanged += xsBindingSource_PositionChanged;
        }

        void xsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            // Son Kayıtta konumlandı ise
            if (this.Position == this.Count - 1)
            {
                if (this.DataSource is xsQuery)
                {
                    xsQuery Query = (this.DataSource as xsQuery);
                    if (Query.Rows.Count == this.Count)
                    {
                        if (Query.DataOptions.Fetching)
                        {
                            Query.ReadData();
                            this.PositionChanged -= xsBindingSource_PositionChanged;
                            this.MoveNext();
                            this.PositionChanged += xsBindingSource_PositionChanged;
                        }
                    }
                }
            }
        }


    }

    #endregion
}
