using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var bloglar = db.TblBlok.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var bloklar2 = db.TblKategori.ToList();
            Repeater2.DataSource = bloklar2;
            Repeater2.DataBind();

            var bloklar3 = db.TblBlok.Take(5).ToList();
            Repeater3.DataSource = bloklar3;
            Repeater3.DataBind();

            var yorum = db.TblYorum.ToList();
            Repeater4.DataSource = yorum;
            Repeater4.DataBind();
        }
    }
}