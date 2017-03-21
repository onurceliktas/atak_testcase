using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atak_testcase.admin
{
    public partial class yoneticiler : System.Web.UI.Page
    {
        atak_testcaseEntities1 et1 = new atak_testcaseEntities1();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string kullaniciadi = Convert.ToString(Session["yoneticiKullaniciAdi"]);

            if (Session["yoneticiKullaniciAdi"] == null)
            {
                Response.Redirect("giris.aspx");
            }
            if (Page.IsPostBack == false)
            {

                using (atak_testcaseEntities1 db = new atak_testcaseEntities1())
                {

                    Yonetici y = et1.Yonetici
                    .First(i => i.yoneticiKullaniciAd == kullaniciadi);// kullanici adi session'dan geleni al
                    txt_adsoyad.Text = y.yoneticiAdSoyad;
                    txt_email.Text = y.yoneticiEmail;
                    txt_kullaniciadi.Text = y.yoneticiKullaniciAd;

                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("yoneticiler.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = Convert.ToString(Session["yoneticiKullaniciAdi"]);
            try
            {
                if (txt_sifre.Text == txt_sifreonay.Text)
                {
                    Yonetici y = et1.Yonetici
                 .First(i => i.yoneticiKullaniciAd == kullaniciadi);
                    y.yoneticiSifre = txt_sifre.Text;
                    y.yoneticiEmail = txt_email.Text;
                    et1.SaveChanges();
                    Response.Redirect("yoneticiler.aspx");
                }
                else
                {
                    Label2.Text = "sifreler uyusmadi";
                }





            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}