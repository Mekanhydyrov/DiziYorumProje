using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class BlokDetay : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Blokid"]);
            var blok = db.TblBlok.Where(x => x.Blokid == id).ToList();
            Repeater1.DataSource = blok;
            Repeater1.DataBind();

            var blok2 = db.TblYorum.Where(x => x.YorumBlok == id).ToList();
            Repeater2.DataSource = blok2;
            Repeater2.DataBind();
        }

        protected void BtnYorum_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Blokid"]);

            TblYorum y = new TblYorum();
            y.KullaniciAd = TxtAd.Text;
            y.Mail = TxtMail.Text;
            y.Yorumicerik = TxtYorum.Text;
            y.YorumBlok = id;
            db.TblYorum.Add(y);
            db.SaveChanges();
            Response.Redirect("BlokDetay.aspx?Blokid=" + id);
        }
    }
}