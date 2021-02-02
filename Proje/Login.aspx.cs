using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Login : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGiris_Click1(object sender, EventArgs e)
        {
            var sorgu = from x in db.TblAdmin
                        where
                    x.Kullanici == TxtAd.Text && x.Sifre == TxtSifre.Text
                        select x;
            if (sorgu.Any())
            {
                Session.Add("Kullanici", TxtAd.Text);

                Response.Redirect("/Admin/Bloklar.aspx");
            }
            else
            {
                Response.Write("Hata");
            }
        }
    }
}