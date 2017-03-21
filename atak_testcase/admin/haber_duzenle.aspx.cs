using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atak_testcase.admin
{
    public partial class haber_duzenle : System.Web.UI.Page
    {
        atak_testcaseEntities1 et1 = new atak_testcaseEntities1();
        int haberID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            haberID = Convert.ToInt32(Request.QueryString["haberID"]);

            
            


            if (Page.IsPostBack == false)
            {
                ////SqlConnection baglanti = new SqlConnection(@"Data Source=HALE-BILGISAYAR\SQLEXPRESS; initial Catalog=atak_testcase; integrated security=true; uid=HALE-BILGISAYAR\SQLEXPRESS; pwd=NULL");


                //////      SqlConnection baglanti = new SqlConnection("Data Source=.; Initial Catalog=siteDB; Integrated Security=true");
                ////baglanti.Open();
                ////SqlConnection.ClearPool(baglanti);
                ////SqlConnection.ClearAllPools();

                ////SqlCommand cmdkguncelle = new SqlCommand("select * from haber where haberID='" + haberID + "'", baglanti);
                ////SqlDataReader drkguncelle = cmdkguncelle.ExecuteReader();             
                //DataRow row = dt.Rows[0];
                //txt_haberbaslik.Text = row["haberBaslik"].ToString();
                //txt_habericerik.Text = row["haberIcerik"].ToString();
                //txt_habertag.Text = row["haberTag"].ToString();

                using (atak_testcaseEntities1 db = new atak_testcaseEntities1())
                {

                    Haber h = et1.Haber
                    .First(i => i.haberID == haberID);//Id = 1 olan kaydı bul
                    txt_haberbaslik.Text = h.haberBaslik;
                    txt_habericerik.Text = h.haberIcerik;
                    txt_habertag.Text = h.haberTag;


                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Haber h = et1.Haber
                    .First(i => i.haberID == haberID);
                h.haberBaslik = txt_haberbaslik.Text;
                h.haberIcerik = txt_habericerik.Text;
                h.haberTarih = DateTime.Now;
                h.haberTag = txt_habertag.Text;
                et1.SaveChanges();
                Response.Redirect("haberler.aspx");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
