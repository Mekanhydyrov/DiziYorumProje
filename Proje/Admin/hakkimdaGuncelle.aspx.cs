using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.Admin
{
    public partial class hakkimdaGuncelle : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = int.Parse(Request.QueryString["id"]);

            if (IsPostBack == false)
            {
                var Guncelle = (from x in db.TblHakkimizda
                           select new
                           {
                               x.iletisimAciklama,
                               x.Hakkimda
                           }).ToList();
               

                var deger = db.TblHakkimizda.Find(i);
                Txtiletisim.Text = deger.iletisimAciklama;
                TxtHakkimda.Text = deger.Hakkimda;
            }
        }

        protected void BtnKayit_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["id"]);
            var blok = db.TblHakkimizda.Find(y);
            blok.iletisimAciklama = Txtiletisim.Text;
            blok.Hakkimda = TxtHakkimda.Text;

            db.SaveChanges();
            Response.Redirect("hakkimda.aspx");
        }
    }
}