<%@ Page Title="" Language="C#" MasterPageFile="~/organiser.master" AutoEventWireup="true" CodeFile="Donate.aspx.cs" Inherits="Donate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            font-size: xx-large;
            color: #333399;
            text-align: center;
        }
        .auto-style6 {
            height: 25px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="5" cellspacing="3" border="1" align="center" width="70%">
        <tr>
            <td class="auto-style5" colspan="2"><strong><em>Donate</em></strong></td>
        </tr>
        <tr>
            <td class="auto-style6">Camp Name</td>
            <td class="auto-style6">
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cname" DataValueField="cname">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:blood_donationConnectionString %>" SelectCommand="SELECT DISTINCT [cname] FROM [camp]"></asp:SqlDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Total Doner</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Blood Unit Collected</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Button ID="Button1" runat="server" Text="Donate" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

