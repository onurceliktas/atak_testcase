<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="haber_duzenle.aspx.cs" Inherits="atak_testcase.admin.haber_duzenle" %>
<%@ Register assembly="CKEditor.NET" namespace="CKEditor.NET" tagprefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 101px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

    <table class="style1">
        <tr>
            <td class="style2">
                Haber Baslik:
            </td>
            <td>
                <asp:TextBox ID="txt_haberbaslik" runat="server" CssClass="textboxstyle" 
                    Width="403px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Haber Icerik:</td>
            <td>
                <CKEditor:CKEditorControl ID="txt_habericerik" BorderColor="Black" BorderStyle="Solid"
                        BorderWidth="1px" runat="server"></CKEditor:CKEditorControl>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Haber Tag:</td>
            <td >
                    <asp:TextBox ID="txt_habertag" runat="server" BorderColor="Black" BorderStyle="Solid"
                        BorderWidth="1px" Height="100px" Width="273px" TextMode="MultiLine"></asp:TextBox>
                    &nbsp;&nbsp; Lutfen tag'ler arasina virgul koyunuz
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
