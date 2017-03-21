using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atak_testcase.admin
{
    public partial class fotograf_ekle : System.Web.UI.Page
    {
        atak_testcaseEntities1 et1 = new atak_testcaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/webimages/" + FileUpload1.FileName));
                Fotograf yeni_foto = new Fotograf();
                yeni_foto.fotografAciklama = txt_foto_aciklama.Text;
                yeni_foto.fotografYol =  ("~/webimages/" + FileUpload1.FileName); //FileUpload1.FileName;
                et1.Fotograf.AddObject(yeni_foto);
                et1.SaveChanges();
                Response.Redirect("foto_galeri.aspx");
            }
            else
            {
                Label2.Text = "Resim Ekleyiniz!";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("foto_galeri.aspx");
        }
    }
}