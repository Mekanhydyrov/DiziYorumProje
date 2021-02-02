using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.Admin
{
    public partial class Bloklar : System.Web.UI.Page
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
                var tur = (from x in db.TblBlok
                           select new
                           {
                               x.Blokid,
                               x.BlokBaslik,
                               x.BlokTarih,
                               x.TblTur.TurAd,
                               x.TblKategori.KategoriAd
                               
                           }).ToList();
                Repeater1.DataSource = tur;
                Repeater1.DataBind();
            }
        }
    
    }
}