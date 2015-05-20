using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lesson3
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rblOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblOrientation.SelectedValue == "Vertical")
            {
                banner1.FindControl("pnlVertical").Visible = true;
                banner1.FindControl("pnlHorizontal").Visible = false;
            }
            else
            {
                banner1.FindControl("pnlVertical").Visible = false;
                banner1.FindControl("pnlHorizontal").Visible = true;
            }
        }
    }
}