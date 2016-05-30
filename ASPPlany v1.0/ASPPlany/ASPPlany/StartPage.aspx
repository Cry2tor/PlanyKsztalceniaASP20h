<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="ASPPlany.StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Plany Kształcenia</title>
</head>
<body style="height: 671px">
    
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" BackColor="#C66300" Height="50px">
            <asp:Button ID="btnHome" runat="server" Text="Strona Główna" BackColor="#C66300" BorderStyle="None" ForeColor="White" Height="50px" Width="100px" />
            <asp:Button ID="Button2" runat="server" Text="Zaloguj" BackColor="#C66300" BorderStyle="None" ForeColor="White" Height="50px" Width="90px" />
            <asp:Button ID="Button3" runat="server" BackColor="#C66300" BorderStyle="None" ForeColor="White" Height="50px" Text="Button" Visible="False" Width="90px" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#436280" Height="622px">
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="panelLogin" runat="server" Direction="LeftToRight" Height="300px" HorizontalAlign="Center" Width="400px">
                <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Zaloguj się jako :"></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnStudent" runat="server" Height="30px" OnClick="btnStudent_Click" Text="Student" Width="90px" />
                <asp:Button ID="btnWykladowca" runat="server" Height="30px" OnClick="btnWykladowca_Click" Text="Wykładowca" Width="90px" />
                <asp:Button ID="btnPracownik" runat="server" Height="30px" OnClick="btnPracownik_Click" Text="Pracownik" Width="90px" />
                <asp:Panel ID="panelLogowanie" runat="server" Height="227px" Visible="False">
                    <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Logowanie"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Login :"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tbLogin" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="labelZlyLogin" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="zły login" Visible="False"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" ForeColor="White" Text="Hasło :"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="tbHaslo" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;
                    <asp:Label ID="labelZleHaslo" runat="server" Font-Bold="True" ForeColor="Red" Text="złe hasło" Visible="False"></asp:Label>
                    <br />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnZaloguj" runat="server" Height="30px" OnClick="btnZaloguj_Click" Text="Zaloguj" Width="89px" />
                </asp:Panel>
            </asp:Panel>
        </asp:Panel>
    </form>
    
    </body>
</html>
