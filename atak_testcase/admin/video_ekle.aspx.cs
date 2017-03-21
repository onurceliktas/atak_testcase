using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atak_testcase.admin
{
    public partial class video_ekle : System.Web.UI.Page
    {
        atak_testcaseEntities1 et1 = new atak_testcaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txt_videoyol.Text.Length==11)
            {
                Video yeni_video = new Video();
            yeni_video.videoAciklama = txt_video_aciklama.Text;
            yeni_video.videoYol = txt_videoyol.Text; 
            et1.Video.AddObject(yeni_video);
            et1.SaveChanges();
            Response.Redirect("video_galeri.aspx");
            }
            else
            {
                Label2.Text = "UYARI: lütfen youtube videosunun son 11 hanesini giriniz";
            }
            
        }
    }
}