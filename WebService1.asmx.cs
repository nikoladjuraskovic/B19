using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace B19
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        public class Slova
        {
            Dictionary<string, string> recnik;

            public Dictionary<string, string> vratiRecnik()
            {
                recnik = new Dictionary<string, string>();

                recnik.Add("Љ", "Lj");
                recnik.Add("Њ", "Nj");
                recnik.Add("Џ", "Dž");
                recnik.Add("љ", "lj");
                recnik.Add("њ", "nj");
                recnik.Add("џ", "dž");
                recnik.Add("а", "a");
                recnik.Add("б", "b");
                recnik.Add("в", "v");
                recnik.Add("г", "g");
                recnik.Add("д", "d");
                recnik.Add("ђ", "đ");
                recnik.Add("е", "e");
                recnik.Add("ж", "ž");
                recnik.Add("з", "z");
                recnik.Add("и", "i");
                recnik.Add("ј", "j");
                recnik.Add("к", "k");
                recnik.Add("л", "l");
                recnik.Add("м", "m");
                recnik.Add("н", "n");
                recnik.Add("о", "o");
                recnik.Add("п", "p");
                recnik.Add("р", "r");
                recnik.Add("с", "s");
                recnik.Add("т", "t");
                recnik.Add("ћ", "ć");
                recnik.Add("у", "u");
                recnik.Add("ф", "f");
                recnik.Add("х", "h");
                recnik.Add("ц", "c");
                recnik.Add("ч", "č");
                recnik.Add("ш", "š");

                return recnik;
            }
        }

        [WebMethod]
        public string CirilicaULatinicu(string tekst)
        {
            Slova slova = new Slova();
            Dictionary<string, string> recnik = slova.vratiRecnik();
            foreach (KeyValuePair<string, string> x in recnik)
            {
                tekst = tekst.Replace(x.Key, x.Value);
                // za velika slova
                tekst = tekst.Replace(x.Key.ToUpper(), x.Value.ToUpper());
            }
            return tekst;
        }

        [WebMethod]
        public string LatinicaUCirilicu(string tekst)
        {
            Slova slova = new Slova();
            Dictionary<string, string> recnik = slova.vratiRecnik();
            foreach (KeyValuePair<string, string> x in recnik)
            {
                tekst = tekst.Replace(x.Value, x.Key);
                // za velika slova
                tekst = tekst.Replace(x.Value.ToUpper(), x.Key.ToUpper());
            }
            return tekst;
        }
    }
}
