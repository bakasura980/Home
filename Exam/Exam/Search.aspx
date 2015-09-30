<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Exam.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="SearchExist" runat="server" />
        <div>
            <asp:LinkButton PostBackUrl="~/Home.aspx" Text="Home" runat="server"/>    
        <div/>
        <br/><br/>
        <asp:DropDownList AutoPostBack="true" ID="Selectitem" runat="server" OnSelectedIndexChanged="Selectitem_SelectedIndexChanged">
        <asp:ListItem Text="Държава"/>
        <asp:ListItem Text="Столица"/>
        <asp:ListItem Text="Население"/>
        </asp:DropDownList>
        <br/><br/>
        <asp:Label ID="CountrySLabel" runat="server" Text="Въведете държава : "/>
        <asp:TextBox ID="CountrySTxtBox" runat="server" Enabled="false" AutoPostBack="true"/>
        <br><br/>
        <asp:Label ID="CapitalSLabel" runat="server" Text="Въведете столица : "/>
        <asp:TextBox ID="CapitalSTxtBox" runat="server" Enabled="false" AutoPostBack="true"/>
        <br><br/>
        <asp:Label ID="PopulationSLabel" runat="server" Text="Въведете население : "/>
        <asp:TextBox ID="PopulationSTxtBox" runat="server" Enabled="false" AutoPostBack="true" TextMode="Number"/>
        <br><br/>
        <asp:Button ID="SearchBtn" runat="server" Text="Търси" OnClick="SearchBtn_Click"/>
        <br/><br/>
        <asp:Label ID="PrintCountryLabel" runat="server" />
        <br/><br/>
        <asp:Label ID="PrintCapitalLabel" runat="server" />
        <br/><br/>
        <asp:Label ID="PrintPopulationLabel" runat="server" />
    </div>
    </form>
</body>
</html>
