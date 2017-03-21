using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atak_testcase
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        atak_testcaseEntities1 et1 = new atak_testcaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //var matches = from c in et1.Yonetici
            //              where c.yoneticiKullaniciAd.Equals(txt_kullaniciadi.Text)
            //              where c.yoneticiSifre.Equals(txt_sifre.Text)
            //              select c;
            try
            {
using (atak_testcaseEntities1 db = new atak_testcaseEntities1())
            {

                Yonetici y = et1.Yonetici
                .First(i => i.yoneticiKullaniciAd == txt_kullaniciadi.Text && i.yoneticiSifre == txt_sifre.Text);//Id = fotografID olan kaydı bul
                if (y.yoneticiKullaniciAd == txt_kullaniciadi.Text && y.yoneticiSifre==txt_sifre.Text)
                {
                    Session["yoneticiKullaniciAdi"] = txt_kullaniciadi.Text;
                    Response.Redirect("haberler.aspx");
                }

            }
            }
            catch (Exception)
            {

                Label1.Text = "hatali giris";
            }
            
        }
    }
}