using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.Admin
{
    public partial class MesajSil : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(Request.QueryString["Mesajid"]);

            var sil = db.Tbliletisim.Find(i);
            db.Tbliletisim.Remove(sil);
            db.SaveChanges();
            Response.Redirect("Mesajlar.aspx");
        }
    }
}