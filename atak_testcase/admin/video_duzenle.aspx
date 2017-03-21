<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="video_duzenle.aspx.cs" Inherits="atak_testcase.admin.video_duzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>

    <table class="style1" >
        
        <tr>
            <td class="style2">
               Video Aciklama:</td>
            <td>
                <CKEditor:CKEditorControl ID="txt_videoAciklama" BorderColor="Black" BorderStyle="Solid"
                        BorderWidth="1px" runat="server"></CKEditor:CKEditorControl>
            </td>
        </tr>
        <tr>
            <td class="style2">
                 Video:
            </td>
            <td>
               
                <asp:TextBox ID="txt_videoyol" runat="server" BorderColor="Black" 
                    BorderStyle="Solid" BorderWidth="1px" MaxLength="11" Width="200px"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="youtube linki son 11 hanesi"></asp:Label>
               
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td >
                    <asp:Button ID="Button1" runat="server" Text="Guncelle" BorderStyle="Solid" 
                        BorderWidth="1px" onclick="Button1_Click"  />&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Iptal" BorderStyle="Solid" 
                        BorderWidth="1px" />
                </td>
        </tr>
    </table>

</div>
</asp:Content>
