using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atak_testcase.admin
{
    public partial class video_duzenle : System.Web.UI.Page
    {
        atak_testcaseEntities1 et1 = new atak_testcaseEntities1();
        int videoID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            videoID = Convert.ToInt32(Request.QueryString["videoID"]);
            if (Page.IsPostBack == false)
            {

                using (atak_testcaseEntities1 db = new atak_testcaseEntities1())
                {

                    Video v = et1.Video
                    .First(i => i.videoID == videoID);//Id = videoID olan kaydı bul
                    txt_videoAciklama.Text = v.videoAciklama;

                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_videoyol.Text == "")
                {
                    Video v = et1.Video
                   .First(i => i.videoID == videoID);
                    v.videoAciklama = txt_videoAciklama.Text;
                    et1.SaveChanges();
                    Response.Redirect("video_galeri.aspx");
                }
                else
                {
                    if (txt_videoyol.Text.Length == 11)
                    {
                        Video v = et1.Video
                        .First(i => i.videoID == videoID);
                        v.videoAciklama = txt_videoAciklama.Text;
                        v.videoYol = txt_videoyol.Text;
                        et1.SaveChanges();
                        Response.Redirect("video_galeri.aspx");
                    }
                    else
                    {
                        Label2.Text = "UYARI: youtube linki son 11 hanesi";
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}