using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.Admin
{
    public partial class BlokGuncelle : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = int.Parse(Request.QueryString["Blokid"]);

            if (IsPostBack == false)
            {
                var tur = (from x in db.TblTur
                           select new
                           {
                               x.TurAd,
                               x.Turid
                           }).ToList();
                DropDownList1.DataSource = tur;
                DropDownList1.DataBind();

                var kategori = (from x in db.TblKategori
                                select new
                                {
                                    x.KategoriAd,
                                    x.Kategoriid
                                }).ToList();
                DropDownList2.DataSource = kategori;
                DropDownList2.DataBind();

                var deger = db.TblBlok.Find(i);
                TxtBaslik.Text = deger.BlokBaslik;
                TxtTarih.Text = deger.BlokTarih.ToString();
                TxtGorsel.Text = deger.BlokGorsel;
                Txticerik.Text = deger.Blokicerik;
               
                DropDownList1.SelectedValue = deger.BlokTur.ToString();
                DropDownList2.SelectedValue = deger.BlokKategori.ToString();
            }
        }

        protected void BtnKayit_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["Blokid"]);
            var blok = db.TblBlok.Find(y);
            blok.BlokBaslik = TxtBaslik.Text;
            blok.BlokTarih = DateTime.Parse(TxtTarih.Text);
            blok.BlokGorsel = TxtGorsel.Text;
            blok.BlokTur = byte.Parse(DropDownList1.SelectedValue);
            blok.BlokKategori = byte.Parse(DropDownList2.SelectedValue);
            blok.Blokicerik = Txticerik.Text;

            db.SaveChanges();
            Response.Redirect("Bloklar.aspx");
        }
    }
}