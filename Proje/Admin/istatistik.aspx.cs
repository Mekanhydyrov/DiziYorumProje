using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.Admin
{
    public partial class istatistik : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }

            LblBlok.Text = db.TblBlok.Count().ToString();
            LblYorum.Text = db.TblYorum.Count().ToString();
            LblFilim.Text = db.TblBlok.Where(i => i.BlokTur == 2).Count().ToString();
            LblAnimasiyon.Text = db.TblBlok.Where(x => x.TblTur.TurAd == "Animasiyon").Count().ToString();
            LblDizi.Text = db.TblBlok.Where(i => i.TblTur.TurAd == "Dizi").Count().ToString();
            LblYorumBlok.Text = db.TblBlok.Where(y => y.Blokid == (db.TblYorum.GroupBy(x => x.YorumBlok)
            .OrderByDescending(x => x.Count()).Select(z => z.Key).FirstOrDefault())).Select(k => k.BlokBaslik).FirstOrDefault();
        }
    }
}