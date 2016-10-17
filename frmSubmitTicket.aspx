<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSubmitTicket.aspx.cs" Inherits="CIS_407_Inventory.frmSubmitTicket" %>

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
        <asp:Label ID="lblTicketResult" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblTicketForm" runat="server" Text="Form"></asp:Label>
        <br />
        <asp:TextBox ID="txtTicketForm" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblErrorDescriptionofError" runat="server" Text="Discription of Error"></asp:Label>
        <br />
        <asp:TextBox ID="txtTicketDiscription" runat="server" Height="382px" TextMode="MultiLine" Width="874px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnTicketSubmit" runat="server" Text="Submit" OnClick="btnTicketSubmit_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
