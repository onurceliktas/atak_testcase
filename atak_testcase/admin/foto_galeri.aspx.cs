using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace atak_testcase.admin
{
   
    public partial class foto_galeri : System.Web.UI.Page
    {
        atak_testcaseEntities1 et1 = new atak_testcaseEntities1();
        string islem = "";
        int fotografID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            islem = Request.QueryString["islem"];
            fotografID = Convert.ToInt32(Request.QueryString["fotografID"]);




            if (islem == "sil")
            {

                var silinecek_foto = et1.Fotograf.Where(w => w.fotografID == fotografID).FirstOrDefault();
                //Model örneği üzerinden Makale tablomuza erişip Remove() methotunu kullanıyoruz.
                if (silinecek_foto != null)
                {
                    et1.Fotograf.Attach(silinecek_foto);
                    et1.Fotograf.DeleteObject(silinecek_foto);
                    et1.SaveChanges(); // ile değişiklikleri kaydediyoruz. ve işlemimiz sona eriyor.
                }

            }


            if (Page.IsPostBack == false)
            {
                DataList1.DataSource = et1.Fotograf;
                DataList1.DataBind();
                var sorgu = from c in et1.Fotograf
                            select new
                            {
                                c.fotografID,
                                c.fotografYol,
                                c.fotografAciklama,
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