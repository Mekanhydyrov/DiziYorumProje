using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.Admin
{
    public partial class Mesajlar : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"]==null)
            {
                Response.Redirect("~/ Login.aspx");
            }

            var x = db.Tbliletisim.ToList();
            Repeater1.DataSource = x;
            Repeater1.DataBind();
        }
    }
}