<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true"
    CodeBehind="video_galeri.aspx.cs" Inherits="atak_testcase.admin.video_galeri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 276px;
        }
        .style4
        {
            width: 16px;
            height: 16px;
        }
        .style5
        {
            width: 513px;
        }
        .style6
        {
            width: 349px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="style1">
                    <tr>
                        <td class="style6" style="text-decoration: underline; font-weight: bolder; ">
                            Video</td>
                        <td class="style5" style="text-decoration: underline; font-weight: bolder; ">
                            Video Aciklama</td>
                        <td style="text-decoration: underline; font-weight: bolder; ">
                            Islem<img alt="" class="style4" src="../img/ekle.png" /></td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <div style="height: 200px; width: 250px;">
                                <iframe width="100%" style="padding: 0;" src="http://youtube.com/v/<%# Eval("videoYol") %>"
                                    frameborder="0"></iframe></td>
                        <td class="style5">
                            <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("videoAciklama") %>'></asp:Literal>
                        </td>
                        <td>
                            <img alt="" class="style4" src="../img/duzenle.gif" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <img alt="" class="style4" src="../img/sil.gif" />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
<cc1:CollectionPager ID="CP1" runat="server" SliderSize="1" ShowPageNumbers="True"
            LabelText="Sayfa" PageSize="5" NextText="İleri" LastText="Son" BackText="Geri"
            FirstText="İlk">
        </cc1:CollectionPager>
    </div>
</asp:Content>
