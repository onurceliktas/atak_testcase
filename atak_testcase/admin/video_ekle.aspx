<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="video_ekle.aspx.cs" Inherits="atak_testcase.admin.video_ekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
        <table class="style1">
            
            <tr>
                <td class="style2">
                    Video Aciklama:
                </td>
                <td>
                    <ckeditor:ckeditorcontrol ID="txt_video_aciklama" BorderColor="Black" BorderStyle="Solid"
                        BorderWidth="1px" runat="server" Width="610px"></ckeditor:ckeditorcontrol>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Video Yol
                </td>
                <td>
                    
                    <asp:TextBox ID="txt_videoyol" runat="server" BorderColor="Black" 
                        BorderStyle="Solid" BorderWidth="1px" CssClass="textboxstyle" 
                        Width="200px" MaxLength="11"></asp:TextBox>
                    
                    <asp:Label ID="Label2" runat="server">youtube linkinin son 11 hanesini giriniz</asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td >
                    <asp:Button ID="Button1" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                         Text="Ekle" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" BorderStyle="Solid" BorderWidth="1px" 
                        Text="Iptal"  />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
