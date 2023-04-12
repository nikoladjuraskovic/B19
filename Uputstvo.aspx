<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uputstvo.aspx.cs" Inherits="B19.Uputstvo" %>

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

                <div class="uputstvo">

                    <h2>Uputstvo</h2>

                    Onlajn portal za prevodjenje latiničnog teksta u ćirilični i obrnuto korišćenjem XML veb servisa.
                    Korisnik u tekstualna polje može uneti tekst i klikom na odgovarajuće dugme vrši se prevodjenje teksta.
                    Aplikacija je urađena u ASP.NET WebForms(.NET Framework 4.8) tehnologiji i povezuje se na XML veb servis.

                </div>
            </div>
        </div>
        <div class="footer">
            <div class="fcol1">
                Elektrotehnička škola "Zemun" Beograd
            </div>
            <div class="fcol2">              
                <a class="a" href="/Konvertor.aspx">Početna</a>
                <a class="a" href="/Uputstvo.aspx">O autoru</a>
                
            </div>           
        </div>


        </div>
    </form>
</body>
</html>
