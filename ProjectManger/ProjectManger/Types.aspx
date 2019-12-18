<%@ Page Title="" Language="C#" MasterPageFile="~/PMS.Master" AutoEventWireup="true" CodeBehind="Types.aspx.cs" Inherits="ProjectManger.Types" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <div style="background-color:azure;text-align:center; width:20%; margin: 20px auto;">
        <h1>this is a types page</h1>
        <table border="1" style="width:100%">
            <tr>
                <td style="width: 131px">Type Name: </td>
                <td><asp:TextBox ID="txtTypeName" runat="server" Width="100%" style="margin-left: 0px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 131px"><asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="100%" OnClick="btnSubmit_Click" /></td>
                <td><asp:Label ID="lblMsg" runat="server" Text="" Width="100%"></asp:Label> </td>
            </tr>
        </table>
    </div>

</asp:Content>
