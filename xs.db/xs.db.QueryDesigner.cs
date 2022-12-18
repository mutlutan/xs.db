using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.Design; //add System.Design

namespace xs.db
{
    #region xsQueryDesigner
    public class xsQueryDesigner : System.ComponentModel.Design.ComponentDesigner
    {
        public xsQueryDesigner()
        {
        }

        DesignerVerbCollection verbs;

        protected override void PostFilterProperties(System.Collections.IDictionary properties)
        {
            //properties.Remove("Filter");             
        }

        public override DesignerVerbCollection Verbs
        {
            get
            {
                if (verbs == null)
                {
                    verbs = new DesignerVerbCollection();
                    verbs.Add(new DesignerVerb("Read Schema", new EventHandler(fReadSchema)));
                    verbs.Add(new DesignerVerb("Remove Schema", new EventHandler(fRemoveSchema)));
                    verbs.Add(new DesignerVerb("Open", new EventHandler(fOpen)));
                    verbs.Add(new DesignerVerb("Close", new EventHandler(fClose)));
                }
                return verbs;
            }
        }

        private void fReadSchema(object sender, EventArgs arg)
        {
            ((xsQuery)(this.Component)).ReadSchema();
        }

        private void fRemoveSchema(object sender, EventArgs arg)
        {
            ((xsQuery)(this.Component)).RemoveSchema();
        }

        private void fOpen(object sender, EventArgs arg)
        {
            ((xsQuery)(this.Component)).Open();
        }

        private void fClose(object sender, EventArgs arg)
        {
            ((xsQuery)(this.Component)).Close();
        }

    }
    #endregion
}
