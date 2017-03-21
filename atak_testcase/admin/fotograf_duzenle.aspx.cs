using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atak_testcase.admin
{
    public partial class fotograf_duzenle : System.Web.UI.Page
    {
        atak_testcaseEntities1 et1 = new atak_testcaseEntities1();
        int fotografID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            fotografID = Convert.ToInt32(Request.QueryString["fotografID"]);
            if (Page.IsPostBack == false)
            {

                using (atak_testcaseEntities1 db = new atak_testcaseEntities1())
                {

                    Fotograf f = et1.Fotograf
                    .First(i => i.fotografID == fotografID);//Id = fotografID olan kaydı bul
                    txt_fotoaciklama.Text = f.fotografAciklama;

                }

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (FileUpload1.HasFile)
                {
                    FileUpload1.SaveAs(Server.MapPath("~/webimages/" + FileUpload1.FileName));
                    Fotograf f = et1.Fotograf
                   .First(i => i.fotografID == fotografID);
                    f.fotografAciklama = txt_fotoaciklama.Text;
                    f.fotografYol = ("~/webimages/" + FileUpload1.FileName);
                    et1.SaveChanges();
                    Response.Redirect("foto_galeri.aspx");
                }
                else
            {
               Fotograf f = et1.Fotograf
                   .First(i => i.fotografID == fotografID);
                    f.fotografAciklama = txt_fotoaciklama.Text;
                    et1.SaveChanges();
                    Response.Redirect("foto_galeri.aspx");
            }


            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}