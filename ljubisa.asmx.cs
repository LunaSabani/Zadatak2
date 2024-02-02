using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Mrnjauuuu
{
    /// <summary>
    /// Summary description for ljubisa
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ljubisa : System.Web.Services.WebService
    {

        [WebMethod]
       
        public  string ProcitajJmbg(string ime, string prezime)
        {

            string[] lines = File.ReadAllLines(Server.MapPath("~/App_Data/Korisnici.txt"));
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3 && parts[0].Trim() == ime && parts[1].Trim() == prezime)
                {
                    return($"JMBG pronađen: {parts[2].Trim()}");
                }
            }
            return "JMBG nije pronađen.";


        }
        [WebMethod]
        public  bool DodajNovogKorisnika(string ime, string prezime, string jmbg)
        {
            string newLine = $"{ime} | {prezime} | {jmbg}";
            File.AppendAllText(Server.MapPath("~/App_Data/Korisnici.txt"), $"{newLine}{Environment.NewLine}");
            return true;
        }

        [WebMethod]
        public  List<string> ProcitajSveKorisnike()
        {
            List<string> korisnici = new List<string>();
            string[] lines = File.ReadAllLines(Server.MapPath("~/App_Data/Korisnici.txt"));
            foreach (string line in lines)
            {
                korisnici.Add(line);
            }
            return korisnici;
        }
    }
}
