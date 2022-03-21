<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoWebsite.aspx.cs" Inherits="WebServiceAssignment.DemoWebsite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WorldLine Population Information</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="WorldLine Population Information" runat="server" />
            <hr />
            <asp:Label Text="Enter the Pin code:" runat="server" />
            <asp:TextBox runat="server" ID="TextBoxPinCode" />
            <hr />
            <asp:Button Text="View Population Information" runat="server" ID="ButtonViewPopulationInformation" OnClick="ButtonViewPopulationInformation_Click" />
            <hr />
            <asp:Label Text="" runat="server" ID="LabelMessage" />
            <hr />
            <asp:Label Text="" runat="server" ID="LabelThanksMessage" />
            <hr />
        </div>
    </form>
</body>
</html>
