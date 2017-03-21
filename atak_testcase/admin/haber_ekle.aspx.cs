using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atak_testcase.admin
{
    public partial class haber_ekle : System.Web.UI.Page
    {
        atak_testcaseEntities1 et1 = new atak_testcaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Haber yeni_haber = new Haber();
            yeni_haber.haberBaslik = txt_haberbaslik.Text;
            yeni_haber.haberIcerik = txt_habericerik.Text;
            yeni_haber.haberTag = txt_habertag.Text;
            et1.Haber.AddObject(yeni_haber);
            et1.SaveChanges();
            Response.Redirect("haberler.aspx");
        }

        
    }
}