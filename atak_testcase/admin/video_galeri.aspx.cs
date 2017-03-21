using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atak_testcase.admin
{
    public partial class video_galeri : System.Web.UI.Page
    {
        atak_testcaseEntities1 et1 = new atak_testcaseEntities1();
        string islem = "";
        int videoID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            islem = Request.QueryString["islem"];
            videoID = Convert.ToInt32(Request.QueryString["videoID"]);




            if (islem == "sil")
            {

                var silinecek_video = et1.Video.Where(w => w.videoID == videoID).FirstOrDefault();
                //Model örneği üzerinden Makale tablomuza erişip Remove() methotunu kullanıyoruz.
                if (silinecek_video != null)
                {
                    et1.Video.Attach(silinecek_video);
                    et1.Video.DeleteObject(silinecek_video);
                    et1.SaveChanges(); // ile değişiklikleri kaydediyoruz. ve işlemimiz sona eriyor.
                }

            }




            if (Page.IsPostBack == false)
            {
                DataList1.DataSource = et1.Video;
                DataList1.DataBind();
                var sorgu = from c in et1.Video
                            select new
                            {
                                c.videoID,
                                c.videoYol,
                                c.videoAciklama,
                            };
                DataList1.DataSource = sorgu;
                CP1.DataSource = sorgu.ToArray();
                CP1.BindToControl = DataList1;
                DataList1.DataSource = CP1.DataSourcePaged;
                DataList1.DataBind();

            }
        }
    }
}