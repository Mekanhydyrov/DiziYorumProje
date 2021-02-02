using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class iletisim : System.Web.UI.Page
    {
        DbFilimDiziEntities1 db = new DbFilimDiziEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TblHakkimizda.ToList();
            Repeater1.DataBind();
        }
        
        protected void Btniletisim_Click(object sender, EventArgs e)
        {
            Tbliletisim t = new Tbliletisim();
            t.AdSoyad = TxtAd.Text;
            t.Mail = TxtMail.Text;
            t.Telefon = TxtTelefon.Text;
            t.Konu = TxtKonu.Text;
            t.Mesaj = TxtMesaj.Text;
            db.Tbliletisim.Add(t);
            db.SaveChanges();
        }
    }
}