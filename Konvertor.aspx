<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Konvertor.aspx.cs" Inherits="B19.Konvertor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="header">
            <div class="hcol1">
                Zadatak 9
            </div>
            <div class="hcol2">
                Konvertor teksta           
            </div>           
        </div>
        <div class="main">
            <div class="container">

                <div class="prevod">



                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Tekst na latinici:"></asp:Label>

                    <asp:TextBox ID="TextBox1" runat="server" Height="94px" Rows="6" TextMode="MultiLine" Width="70%"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Prevedi na ćirilicu" OnClick="Button1_Click" />
                    <br />

                </div>

                <hr class="fading_line" />

                <div class="prevod">

                    <asp:Label ID="Label2" runat="server" Text="Tekst na ćirilici:"></asp:Label>

                    <asp:TextBox ID="TextBox2" runat="server" Height="114px" Rows="6" TextMode="MultiLine" Width="70%"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Prevedi na latinicu" OnClick="Button2_Click" />


                </div>
            </div>
        </div>
        <div class="footer">
            <div class="fcol1">
                Elektrotehnička škola "Zemun" Beograd
            </div>
            <div class="fcol2">              
                <a class="a" href="/Uputstvo.aspx">Uputstvo</a>
                <a class="a" href="/Konvertor.aspx">O autoru</a>
                
            </div>           
        </div>


        </div>
    </form>
</body>
</html>
