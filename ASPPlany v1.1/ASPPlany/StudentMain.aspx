<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentMain.aspx.cs" Inherits="ASPPlany.StudentMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student</title>
</head>
<body style="height: 671px">
    
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" BackColor="#C66300" Height="50px">
            <asp:Button ID="btnHome" runat="server" Text="Strona Główna" BackColor="#C66300" BorderStyle="None" ForeColor="White" Height="50px" Width="120px" OnClick="btnHome_Click" />
            <asp:Button ID="btnWykladowcy" runat="server" BackColor="#C66300" BorderStyle="None" ForeColor="White" Height="50px" OnClick="btnWykladowcy_Click" Text="Moi Wykładowcy" Width="120px" />
            &nbsp;&nbsp;<asp:Button ID="btnPrzedmioty" runat="server" BackColor="#C66300" BorderStyle="None" ForeColor="White" Height="50px" OnClick="btnPrzedmioty_Click" Text="Moje Przedmioty" Width="120px" />
            <asp:Button ID="btnGrupa" runat="server" BackColor="#C66300" BorderStyle="None" ForeColor="White" Height="50px" OnClick="btnGrupa_Click" Text="Moja Grupa" Width="120px" />
            <asp:Button ID="btnSpecjalizacja" runat="server" BackColor="#C66300" BorderStyle="None" ForeColor="White" Height="50px" OnClick="btnSpecjalizacja_Click" Text="Specjalizacja" Width="120px" />
            <asp:Button ID="btnStypendium" runat="server" BackColor="#C66300" BorderStyle="None" ForeColor="White" Height="50px" OnClick="btnStypendium_Click" Text="Stypendium" Width="120px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnWyloguj" runat="server" BackColor="#C66300" BorderStyle="None" ForeColor="White" Height="50px" OnClick="btnWyloguj_Click" Text="Wyloguj" Width="120px" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#436280" Height="622px" HorizontalAlign="Left" >
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Witamy w systemie. Wybierz jedną z opcji z powyższego menu:" ForeColor="#CCFFFF"></asp:Label>
            <br />
            <br />
            <br />
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="View5" runat="server">
                    <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource5" Font-Size="Medium" ForeColor="Black" Width="295px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2">
                        <Columns>
                            <asp:BoundField DataField="rodziaj" HeaderText="rodziaj" SortExpression="rodziaj" />
                            <asp:BoundField DataField="kwota" HeaderText="kwota" SortExpression="kwota" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:PlanyKsztalceniaConnectionString %>" SelectCommand="SELECT [rodziaj], [kwota] FROM [Stypendium] WHERE ([rodziaj] = @rodziaj)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Naukowe" Name="rodziaj" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </asp:View>
                <asp:View ID="View4" runat="server">
                    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" Font-Size="Medium" ForeColor="Black" Width="296px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2">
                        <Columns>
                            <asp:BoundField DataField="nazwa" HeaderText="nazwa" SortExpression="nazwa" />
                            <asp:BoundField DataField="stopien" HeaderText="stopien" SortExpression="stopien" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:PlanyKsztalceniaConnectionString %>" SelectCommand="SELECT [nazwa], [stopien] FROM [Specjalnosc] WHERE ([nazwa] = @nazwa)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Programowanie Komputerów" Name="nazwa" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" Font-Size="Medium" ForeColor="Black" Width="427px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2">
                        <Columns>
                            <asp:BoundField DataField="imie" HeaderText="imie" SortExpression="imie" />
                            <asp:BoundField DataField="nazwisko" HeaderText="nazwisko" SortExpression="nazwisko" />
                            <asp:BoundField DataField="plec" HeaderText="plec" SortExpression="plec" />
                            <asp:BoundField DataField="rok_urodzenia" HeaderText="rok_urodzenia" SortExpression="rok_urodzenia" />
                            <asp:BoundField DataField="grupa" HeaderText="grupa" SortExpression="grupa" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:PlanyKsztalceniaConnectionString %>" SelectCommand="SELECT [imie], [nazwisko], [plec], [rok_urodzenia], [grupa] FROM [Studenci] WHERE ([grupa] = @grupa)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="Programowanie1" Name="grupa" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Font-Size="Medium" ForeColor="Black" Width="426px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2">
                        <Columns>
                            <asp:BoundField DataField="nazwa" HeaderText="nazwa" SortExpression="nazwa" />
                            <asp:BoundField DataField="ile_godzin" HeaderText="ile_godzin" SortExpression="ile_godzin" />
                            <asp:BoundField DataField="typ_zajec" HeaderText="typ_zajec" SortExpression="typ_zajec" />
                            <asp:BoundField DataField="semestr" HeaderText="semestr" SortExpression="semestr" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PlanyKsztalceniaConnectionString %>" SelectCommand="SELECT [nazwa], [ile_godzin], [typ_zajec], [semestr] FROM [Przedmioty] WHERE ([Specjalnosc_id_specjalnosc] = @Specjalnosc_id_specjalnosc)">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="1" Name="Specjalnosc_id_specjalnosc" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </asp:View>
                <asp:View ID="View1" runat="server">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Font-Size="Medium" ForeColor="Black" Width="428px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2">
                        <Columns>
                            <asp:BoundField DataField="imie" HeaderText="imie" SortExpression="imie" />
                            <asp:BoundField DataField="nazwisko" HeaderText="nazwisko" SortExpression="nazwisko" />
                            <asp:BoundField DataField="plec" HeaderText="plec" SortExpression="plec" />
                            <asp:BoundField DataField="kategoria" HeaderText="kategoria" SortExpression="kategoria" />
                            <asp:BoundField DataField="stopien" HeaderText="stopien" SortExpression="stopien" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PlanyKsztalceniaConnectionString %>" SelectCommand="SELECT [imie], [nazwisko], [plec], [kategoria], [stopien] FROM [Pracownicy]"></asp:SqlDataSource>
                </asp:View>
            </asp:MultiView>
        </asp:Panel>
    </form>
    
    </body>
</html>