<%@ Page Title="" Language="C#" MasterPageFile="~/PMS.Master" AutoEventWireup="true" CodeBehind="Types.aspx.cs" Inherits="ProjectManger.Types" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>this is a types page</h1>

    <div style="background-color:azure;text-align:center; width:40%; margin: 0px auto;">
    <table border="1">
        <tr>
            <td>Type Name: </td>
            <td><asp:TextBox ID="txtTypeName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="100%" OnClick="btnSubmit_Click" /></td>
            <td><asp:Label ID="lblMsg" runat="server" Text=""></asp:Label> </td>
        </tr>
    </table>
    </div>

</asp:Content>
