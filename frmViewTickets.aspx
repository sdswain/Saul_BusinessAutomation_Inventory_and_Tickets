<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmViewTickets.aspx.cs" Inherits="CIS_407_Inventory.frmViewTickets" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblViewTicketResult" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblTicketDate" runat="server" Text="Ticket Date and ID"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlTicketDate" runat="server" DataSourceID="SqlDataSource10" DataTextField="TicketID" DataValueField="DateOfSubmition">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource10" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT [TicketID], [DateOfSubmition] FROM [Tickets] ORDER BY [DateOfSubmition]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <asp:ListBox ID="lstViewTicket" runat="server" Height="639px" Width="1126px"></asp:ListBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnSubmitView" runat="server" OnClick="btnSubmitView_Click" Text="Submit" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
