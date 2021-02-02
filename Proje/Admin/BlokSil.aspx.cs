using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.Admin
{
    public partial class BlokSil : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["Blokid"]);

            var blok = db.TblBlok.Find(x);
            db.TblBlok.Remove(blok);
            db.SaveChanges();
            Response.Redirect("Bloklar.aspx");
        }
    }
}