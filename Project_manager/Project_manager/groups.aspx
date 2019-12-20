<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster.Master" AutoEventWireup="true" CodeBehind="groups.aspx.cs" Inherits="Project_manager.groups" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </style>
    <div>
        <table style="padding-left:35%">
        <tr>
            <td style="padding-bottom: 5%">
                <strong>Student 1</strong>
            </td>
            <td style="padding-bottom: 5%">
                <asp:DropDownList ID="DropDownList1" DataTextField="regNo" DataValueField="regNo" runat="server" Width="228px" CssClass="auto-style1" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="padding-bottom: 5%">
                <strong>Student 2</strong>
            </td>
            <td style="padding-bottom: 5%">
                <asp:DropDownList ID="DropDownList2" DataTextField="regNo" DataValueField="regNo" runat="server" Width="228px" CssClass="auto-style1">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="padding-bottom: 5%">
                <strong>Student 3</strong>
            </td>
            <td style="padding-bottom: 5%">
                <asp:DropDownList ID="DropDownList3" DataTextField="regNo" DataValueField="regNo" runat="server" Width="228px" CssClass="auto-style1">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="padding-bottom: 5%">
                <strong>Student 4</strong>
            </td>
            <td style="padding-bottom: 5%">
                <asp:DropDownList ID="DropDownList4" DataTextField="regNo" DataValueField="regNo" runat="server" Width="228px" CssClass="auto-style1">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="padding-bottom: 5%">
                <strong>Project</strong>
            </td>
            <td style="padding-bottom: 5%">
                <asp:DropDownList ID="DropDownList5" DataTextField="project name" DataValueField="project name" runat="server" Width="228px" CssClass="auto-style1">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="padding-bottom: 5%">
                <strong>Advisor</strong>
            </td>
            <td style="padding-bottom: 5%">
                <asp:DropDownList ID="DropDownList6" DataTextField="name" DataValueField="name" runat="server" Width="228px" CssClass="auto-style1">
                </asp:DropDownList>
            </td>
        </tr>
            <td class="auto-style1">
                    <asp:Button ID="Submit" runat="server" Font-Size="Medium" Text="Submit" OnClick="Insert_Click" />
            </td>
        </table>          
    </div>

</asp:Content>
