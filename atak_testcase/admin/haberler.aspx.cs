using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Routing;
using System.Web.UI.WebControls;

namespace atak_testcase.admin
{
    public partial class haberler : System.Web.UI.Page
    {

        atak_testcaseEntities1 et1 = new atak_testcaseEntities1();
        string islem = "";
        int haberID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            islem = Request.QueryString["islem"];
            haberID = Convert.ToInt32(Request.QueryString["haberID"]);

            


            if (islem == "sil")
            {

                var silinecek_haber = et1.Haber.Where(w => w.haberID == haberID).FirstOrDefault();
                //Model örneği üzerinden Makale tablomuza erişip Remove() methotunu kullanıyoruz.
                if (silinecek_haber != null)
                {
                    et1.Haber.Attach(silinecek_haber);
                    et1.Haber.DeleteObject(silinecek_haber);
                    et1.SaveChanges(); // ile değişiklikleri kaydediyoruz. ve işlemimiz sona eriyor.
                }

            }


            if (Page.IsPostBack == false)
            {
                DataList1.DataSource = et1.Haber;
                DataList1.DataBind();
                var sorgu = from c in et1.Haber
                            select new
                            {
                                c.haberID,
                                c.haberBaslik,
                                c.haberIcerik,
                                c.haberOkunmaSayisi,
                            };
                DataList1.DataSource = sorgu;
                CP1.DataSource = sorgu.ToArray();
                CP1.BindToControl = DataList1;
                DataList1.DataSource = CP1.DataSourcePaged;
                DataList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CP1.DataSource = "";
            DataList1.DataSource = et1.Haber;
            DataList1.DataBind();
            var matches = from c in et1.Haber
                          where c.haberBaslik.Contains(TextBox1.Text)
                          where c.haberIcerik.Contains(TextBox2.Text)
                          select c;
            DataList1.DataSource = matches;
            CP1.DataSource = matches.ToArray();
            CP1.BindToControl = DataList1;
            DataList1.DataSource = CP1.DataSourcePaged;
            DataList1.DataBind();
        }

        protected void goster()
        {

            //CP1.DataSource = et1.Haber;
            //CP1.BindToControl = DataList1;
            //DataList1.DataSource = CP1.DataSourcePaged;
            //DataList1.DataBind();




            DataList1.DataSource = et1.Haber;
            DataList1.DataBind();
            var sorgu = from c in et1.Haber
                        select new
                        {
                            c.haberID,
                            c.haberBaslik,
                            c.haberIcerik,
                            c.haberOkunmaSayisi,
                        };
            DataList1.DataSource = sorgu;
            DataList1.DataBind();
        }

    }
}