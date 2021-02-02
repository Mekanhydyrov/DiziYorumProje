using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Kategoriid"]);
            var bloglar = db.TblBlok.Where(x => x.BlokKategori == id).ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var bloklar3 = db.TblBlok.Take(5).ToList();
            Repeater2.DataSource = bloklar3;
            Repeater2.DataBind();
        }
    }
}