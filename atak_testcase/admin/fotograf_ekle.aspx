<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="fotograf_ekle.aspx.cs" Inherits="atak_testcase.admin.fotograf_ekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
        <table class="style1">
            
            <tr>
                <td class="style2">
                    Fotograf Aciklama:
                </td>
                <td>
                    <ckeditor:ckeditorcontrol ID="txt_foto_aciklama" BorderColor="Black" BorderStyle="Solid"
                        BorderWidth="1px" runat="server" Width="610px"></ckeditor:ckeditorcontrol>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Fotograf Yol
                </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" BorderColor="Black" 
                        BorderStyle="Solid" BorderWidth="1px" Width="220px" />
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td >
                    <asp:Button ID="Button1" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                        onclick="Button1_Click" Text="Ekle" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                        Text="Iptal" onclick="Button2_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
