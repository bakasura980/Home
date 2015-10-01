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
        <asp:DropDownList AutoPostBack="true" ID="Selectitem" runat="server" OnTextChanged="Selectitem_TextChanged">
        <asp:ListItem Text="Държава"/>
        <asp:ListItem Text="Столица"/>
        <asp:ListItem Text="Население"/>
        </asp:DropDownList>
        <br/><br/>
        <asp:Label ID="CountrySLabel" runat="server" Text="Въведете държава : "/>
        <asp:TextBox ID="CountrySTxtBox" runat="server" Enabled ="false" />
        <br><br/>
        <asp:Label ID="CapitalSLabel" runat="server" Text="Въведете столица : "/>
        <asp:TextBox ID="CapitalSTxtBox" runat="server" Enabled="false"  />
        <br><br/>
        <asp:Label ID="PopulationSLabel" runat="server" Text="Въведете население : "/>
        <asp:TextBox ID="PopulationSTxtBox" runat="server" Enabled="false"   MaxLength="7" />
        <br><br/>
        <asp:Button ID="SearchBtn" runat="server" Text="Търси" OnClick="SearchBtn_Click" AutoPostBack="true"/>
           
        <br/><br/>
             <asp:Repeater runat="server" ID="dataRepeater">
            <ItemTemplate>  
                <asp:Label runat="server" ID="titleLabel" Text='<%# Eval("Country") %>'  />
                <br />
                <asp:Label Text='<%# Eval("Capital") %>' runat="server" />
                <br />
                <asp:Label Text='<%# Eval("Population") %>' runat="server" />
                <br />
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
