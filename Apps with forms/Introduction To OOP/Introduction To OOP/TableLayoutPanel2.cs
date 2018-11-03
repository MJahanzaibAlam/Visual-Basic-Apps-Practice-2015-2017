using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction_To_OOP
{
    public class TableLayoutPanel2 : TableLayoutPanel
    {

        protected override void OnSizeChanged(EventArgs e)

        {

            if (this.Handle != null)

            {

                this.BeginInvoke((MethodInvoker)delegate

                {

                    base.OnSizeChanged(e);

                });

            }

        }

    }
}
