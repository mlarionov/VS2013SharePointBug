using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using ClassLibrary1;
using ClassLibrary2;

namespace VisualWebPartProject1.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var c1 = new Class1();
            var c2 = new Class2();
        }
    }
}
