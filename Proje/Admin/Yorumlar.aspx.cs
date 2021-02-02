using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.Admin
{
    public partial class Yorumlar : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }

            var yorum = (from x in db.TblYorum
                         select new
                         {
                             x.Yorumid,
                             x.KullaniciAd,
                             x.Mail,
                             x.TblBlok.BlokBaslik
                         }).ToList();

            Repeater1.DataSource = yorum;
            Repeater1.DataBind();
        }
    }
}