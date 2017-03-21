<%@ Register Assembly="CollectionPager" Namespace="SiteUtils" TagPrefix="cc1" %>

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true"
    CodeBehind="haberler.aspx.cs" Inherits="atak_testcase.admin.haberler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 293px;
        }
        .style3
        {
            width: 275px;
        }
        .style9
        {
            width: 131px;
        }
        .style12
        {
            width: 16px;
            height: 16px;
        }
        .style13
        {
            width: 59px;
        }
        .style18
        {
            width: 325px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <%--  <div runat="server">--%>
        <table class="style1" style="border: 1px solid #000000;">
            <tr>
                <td class="style2">
                    Haber Baslik:&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" Width="150px" BorderColor="Black"
                        BorderWidth="1px"></asp:TextBox>
                </td>
                <td class="style3">
                    Haber Metni:
                    <asp:TextBox ID="TextBox2" runat="server" BorderColor="Black" BorderStyle="Solid"
                        Width="150px" BorderWidth="1px"></asp:TextBox>
                </td>
                <td style="float: none;">
                    <div style="float: left;">
                        <asp:Button ID="Button1" runat="server" Text="Ara" BorderWidth="1px" OnClick="Button1_Click" /></div>
                    <div style="float: right;">
                        <a href="haber_ekle.aspx">
                            <img src="../img/ekle.png" alt="ekle" /></a>
                    </div>
                </td>
            </tr>
        </table>
        <br />
        <asp:DataList ID="DataList1" runat="server" Width="750px">
            <ItemTemplate>
                <table class="style1" style="border: thin groove #333333;">
                    <tr style="border: thin groove #333333; text-decoration: underline">
                        <td class="style13">
                            Sira
                        </td>
                        <td class="style9">
                            &nbsp; Haber Basligi
                        </td>
                        <td class="style18" style="text-align: center;">
                            &nbsp; Haber Icerik
                        </td>
                        <td class="style9" style="text-align: center;">
                            &nbsp; Okunma
                        </td>
                        <td style="text-align: center;">
                            &nbsp; Islem
                        </td>
                    </tr>
                    <tr>
                        <td class="style13">
                            <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("haberID") %>'></asp:Literal>
                        </td>
                        <td class="style9">
                            <asp:Literal ID="Literal2" runat="server" Text='<%# Eval("haberBaslik") %>'></asp:Literal>
                        </td>
                        <td class="style18">
                            <asp:Literal ID="Literal3" runat="server" Text='<%# Eval("haberIcerik") %>'></asp:Literal>
                        </td>
                        <td class="style9" style="text-align: center;">
                            <asp:Literal ID="Literal4" runat="server" Text='<%# Eval("haberOkunmaSayisi") %>'></asp:Literal>
                        </td>
                        <td style="text-align: center;">
                            &nbsp;&nbsp;
                            <a href="haber_duzenle.aspx?haberID=<%# Eval("haberID") %>">
                                <img alt="" class="style12" src="../img/duzenle.gif" /></a>
                            &nbsp;&nbsp;&nbsp;&nbsp; <a href="haberler.aspx?haberID=<%# Eval("haberID") %>&islem=sil">
                                <img alt="" class="style12" src="../img/sil.gif" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <%--        <a href="haber_duzenle.aspx?haberID=<%# Eval("haberID") %>">
<asp:HyperLink ID="hpy1" runat="server" NavigateUrl="<%$ RouteUrl:Name=haberduzenle, haberID=3 %>">
************<a href="haber_duzenle.aspx?haberID=<%# Eval("haberID") %>">
        <a id="A2" href="<%$ RouteUrl:Featured=False,routename=featured%>" title="Featured" runat="server">
        --%>
        <br />
        <br />
        <br />
        <cc1:CollectionPager ID="CP1" runat="server"  SliderSize="1" ShowPageNumbers="True"
            LabelText="Sayfa" PageSize="5" NextText="İleri" LastText="Son" BackText="Geri"
            FirstText="İlk">
        </cc1:CollectionPager>
   <%-- </div>--%>
</asp:Content>
