<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true"
    CodeBehind="foto_galeri.aspx.cs" Inherits="atak_testcase.admin.foto_galeri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style4
        {
            width: 16px;
            height: 16px;
        }
        .style7
        {
            width: 210px;
        }
        .style8
        {
            width: 429px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <%--        <a href="haber_duzenle.aspx?haberID=<%# Eval("haberID") %>">
<asp:HyperLink ID="hpy1" runat="server" NavigateUrl="<%$ RouteUrl:Name=haberduzenle, haberID=3 %>">
************<a href="haber_duzenle.aspx?haberID=<%# Eval("haberID") %>">
        <a id="A2" href="<%$ RouteUrl:Featured=False,routename=featured%>" title="Featured" runat="server">
        --%>
        <br />
        <asp:DataList ID="DataList1" runat="server" Width="750px">
            <ItemTemplate>
                <table class="style1" style="border: 1px solid #000000;">
                    <tr style="border: thin groove #333333; text-decoration: underline">
                        <td class="style7">
                            Fotograf
                        </td>
                        <td class="style8">
                            Fotograf Aciklama
                        </td>
                        <td>
                            Islem&nbsp;&nbsp; <a href="fotograf_ekle.aspx">
                                <img alt="resim" class="style4" src="../img/ekle.png" /></a>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            <div style="height: 100px; width: 100px;">
                                <asp:Image Style="max-width: 100%; padding: 0;" ID="Image1" runat="server" ImageUrl='<%# Eval("fotografYol") %>' /></div>
                        </td>
                        <td class="style8">
                            <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("fotografAciklama") %>'></asp:Literal>
                        </td>
                        <td>
                            <a href="fotograf_duzenle.aspx?fotografID=<%# Eval("fotografID") %>">
                                <img alt="" class="style4" src="../img/duzenle.gif" /></a> &nbsp;&nbsp;&nbsp;&nbsp;<a
                                    href="foto_galeri.aspx?fotografID=<%# Eval("fotografID") %>&islem=sil"><img alt=""
                                        class="style4" src="../img/sil.gif" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <br />
        <br />
        <cc1:CollectionPager ID="CP1" runat="server" SliderSize="1" ShowPageNumbers="True"
            LabelText="Sayfa" PageSize="5" NextText="İleri" LastText="Son" BackText="Geri"
            FirstText="İlk">
        </cc1:CollectionPager>
    </div>
</asp:Content>
