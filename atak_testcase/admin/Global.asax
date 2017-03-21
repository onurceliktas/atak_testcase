<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>
<script runat="server"> 
void Application_Start(object sender, EventArgs e) 
{
    RegisterRoutes(RouteTable.Routes);
} 

public void RegisterRoutes(RouteCollection routes)
{
routes.MapPageRoute("haberler","haberler/{page}","haberler.aspx"}
}
</script>