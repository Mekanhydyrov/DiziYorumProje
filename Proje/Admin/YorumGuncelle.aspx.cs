using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.Admin
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = int.Parse(Request.QueryString["Yorumid"]);

            if (IsPostBack == false)
            {
                var tur = (from x in db.TblYorum
                           select new
                           {
                               x.KullaniciAd,
                               x.Yorumicerik
                           }).ToList();

                var deger = db.TblYorum.Find(i);
                TxtBaslik.Text = deger.TblBlok.BlokBaslik;
                TxtKullanici.Text = deger.KullaniciAd;
                Txticerik.Text = deger.Yorumicerik;
            }
        }

        protected void BtnKayit_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(Request.QueryString["Yorumid"]);

            var yorum = db.TblYorum.Find(i);
            yorum.KullaniciAd = TxtKullanici.Text;
            yorum.Yorumicerik = Txticerik.Text;

            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}