<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="yoneticiler.aspx.cs" Inherits="atak_testcase.admin.yoneticiler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 144px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <table class="style1">
        <tr>
            <td class="style2">
                Ad Soyad:
            </td>
            <td>
                <asp:TextBox ID="txt_adsoyad" runat="server" BorderColor="Black" 
                    BorderStyle="Solid" BorderWidth="1px" Enabled="False" Height="25px" 
                    Width="200px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <a href="yonetici_ekle.aspx">  <img alt="ekle" src="../img/ekle.png" 
                    style="width: 16px; height: 16px" /></a>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Kullanici Adi:</td>
            <td>
                <asp:TextBox ID="txt_kullaniciadi" runat="server" BorderColor="Black" 
                    BorderStyle="Solid" BorderWidth="1px" Enabled="False" Height="25px" 
                    Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                E-mail</td>
            <td>
                <asp:TextBox ID="txt_email" runat="server" BorderColor="Black" 
                    BorderStyle="Solid" BorderWidth="1px" Height="25px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Sifre:</td>
            <td>
                <asp:TextBox ID="txt_sifre" runat="server" BorderColor="Black" 
                    BorderStyle="Solid" BorderWidth="1px" Height="25px" Width="200px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Sifre Tekrar:</td>
            <td>
                <asp:TextBox ID="txt_sifreonay" runat="server" BorderColor="Black" 
                    BorderStyle="Solid" BorderWidth="1px" CssClass="textboxstyle" Height="25px" 
                    Width="200px"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" BorderColor="Black" BorderStyle="Solid" 
                    BorderWidth="1px" Text="Guncelle" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BorderColor="Black" BorderStyle="Solid" 
                    BorderWidth="1px" onclick="Button2_Click" Text="Iptal" Width="100px" />
            </td>
        </tr>
    </table>
</div>
</asp:Content>
