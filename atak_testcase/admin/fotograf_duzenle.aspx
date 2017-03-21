<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="fotograf_duzenle.aspx.cs" Inherits="atak_testcase.admin.fotograf_duzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>

    <table class="style1">
        
        <tr>
            <td class="style2">
               Fotograf Aciklama:</td>
            <td>
                <CKEditor:CKEditorControl ID="txt_fotoaciklama" BorderColor="Black" BorderStyle="Solid"
                        BorderWidth="1px" runat="server"></CKEditor:CKEditorControl>
            </td>
        </tr>
        <tr>
            <td class="style2">
                 Fotograf:
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" BorderColor="Black" 
                    BorderStyle="Solid" BorderWidth="1px" Width="230px" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td >
                    <asp:Button ID="Button1" runat="server" Text="Guncelle" BorderStyle="Solid" 
                        BorderWidth="1px" onclick="Button1_Click" />&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Iptal" BorderStyle="Solid" 
                        BorderWidth="1px" />
                </td>
        </tr>
    </table>

</div>
</asp:Content>
