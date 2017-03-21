<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="atak_testcase.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 122px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 280px; position:absolute; top:50%; left:50%; margin: -100px 0 0 -150px;">
    
        <table class="style1">
            <tr>
                <td class="style2">
                    Kullanici Adiniz:</td>
                <td>
                    <asp:TextBox ID="txt_kullaniciadi" runat="server" BorderColor="Black" 
                        BorderStyle="Solid" BorderWidth="1px" Height="25px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Sifreniz:</td>
                <td>
                    <asp:TextBox ID="txt_sifre" runat="server" BorderColor="Black" 
                        BorderStyle="Solid" BorderWidth="1px" Height="25px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Giris" BorderColor="Black" 
                        BorderStyle="Solid" BorderWidth="1px" onclick="Button1_Click" />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
