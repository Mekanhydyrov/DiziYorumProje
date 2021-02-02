using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.Admin
{
    public partial class YeniBlok : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }

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
            }
        }

        protected void BtnKayit_Click(object sender, EventArgs e)
        {
            TblBlok t = new TblBlok();
            t.BlokBaslik = TxtBaslik.Text;
            t.BlokTarih = DateTime.Parse(TxtTarih.Text);
            t.BlokGorsel = TxtGorsel.Text;
            t.BlokTur = byte.Parse(DropDownList1.SelectedValue);
            t.BlokKategori = byte.Parse(DropDownList2.SelectedValue);
            t.Blokicerik = Txticerik.Text;
            db.TblBlok.Add(t);
            db.SaveChanges();
            Response.Redirect("Bloklar.aspx");
        }
    }
}