<%@ Page Title="" Language="C#" MasterPageFile="~/organiser.master" AutoEventWireup="true" CodeFile="donar_regi.aspx.cs" Inherits="donar_regi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            font-size: x-large;
            color: #006600;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table cellpadding="5" cellspacing="3" border="1" align="center" width="70%">
        <tr>
            <td class="auto-style5" colspan="2" style="text-align: center"><strong><em>Doner Registration</em></strong></td>
        </tr>
        <tr>
            <td class="auto-style3">Doner I&#39;d</td>
            <td class="auto-style3">
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Doner Name</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Blood Group</td>
            <td class="auto-style3">
                <asp:DropDownList ID="DropDownList1" runat="server"  >
                    <asp:ListItem>O+</asp:ListItem>
                    <asp:ListItem Value="O-">O-</asp:ListItem>
                    <asp:ListItem>A+</asp:ListItem>
                    <asp:ListItem>A-</asp:ListItem>
                    <asp:ListItem>B+</asp:ListItem>
                    <asp:ListItem>B-</asp:ListItem>
                    <asp:ListItem>AB+</asp:ListItem>
                    <asp:ListItem>AB-</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Contact No.</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

