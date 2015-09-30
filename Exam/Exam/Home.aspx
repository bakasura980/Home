<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Exam.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="ExistLabel" runat="server"/>
        <div>
            <asp:LinkButton PostBackUrl="~/Search.aspx" Text="Search county" runat="server"/>    
        <div/>
        <asp:Label ID="CountryLabel" runat="server" Text="Въведете Държава : "/>
        <asp:TextBox ID="CountryTxtBox" runat="server"/>
        <br/><br/>
        <asp:Label ID="CapitalLabel" runat="server" Text="Въведете Столица : "/>
        <asp:TextBox ID="CapitalTxtBox" runat="server"/>
        <br/><br/>
        <asp:Label ID="PopulationLabel" runat="server" Text="Въведете Население : "/>
        <asp:TextBox ID="PopulationTxtBox" runat="server" TextMode="Number"/>
        <br/><br/>
        <asp:Button ID="AddBtn" runat="server" Text="Добавете" OnClick="AddBtn_Click"/>

    </div>
    </form>
</body>
</html>
