<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webpage.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Meddelanden från consollen:</h2>
    </div>
    <div>
        <asp:ListBox ID="ListBoxMessanges" runat="server"></asp:ListBox>
    </div>
        <asp:Button ID="HämtaUppdatera" runat="server" Text="Hämta/uppdatera" OnClick="GetMessanges_Click" />
    </form>
</body>
</html>
