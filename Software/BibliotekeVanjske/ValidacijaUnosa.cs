using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekeVanjske
{
    public static class ValidacijaUnosa
    {
        public static string ProvjeriKorisnickoIme(string korisnickoIme)
        {
            string povratnaPoruka = "";
            if (korisnickoIme.All(Char.IsLetterOrDigit) == false)
            {
                povratnaPoruka += "Korisničko ime može sadržavati samo slova i brojeve!\n";
            }
            if (korisnickoIme == "")
            {
                povratnaPoruka += "Korisničko ime mora biti uneseno!\n";
            }
            if (korisnickoIme.Count() < 3 || korisnickoIme.Count() > 20)
            {
                povratnaPoruka += "Korisničko ime mora imati između 3 i 20 znakova!\n";
            }
            return povratnaPoruka;
        }
      
        public static string ProvjeriOpis(string naziv)
        {
            string povratnaPoruka = "";

            if (naziv.All(c => Char.IsLetterOrDigit(c) || c == ' ' || c == ':' || c == '.' || c == '!' || c == '?' || c == ',') == false)
            {
                povratnaPoruka += "Opis može sadržavati samo slova,brojeve i neke specijalne znakove (?!:.,)!\n";
            }
            if (naziv == "")
            {
                povratnaPoruka += "Opis mora biti unesen!\n";
            }
            return povratnaPoruka;
        }
      

        public static string ProvjeriLozinku(string lozinka)
        {
            string povratnaPoruka = "";
            if (lozinka.All(Char.IsLetterOrDigit) == false)
            {
                povratnaPoruka += "Lozinka može sadržavati samo slova i brojeve!\n";
            }
            if (lozinka == "")
            {
                povratnaPoruka += "Lozinka mora biti unesena!\n";
            }
            if (lozinka.Count() < 5 || lozinka.Count() > 16)
            {
                povratnaPoruka += "Lozinka mora imati najmanje 5 znakova!\n";
            }
            if (lozinka.Count() > 16)
            {
                povratnaPoruka += "Lozinka može imati najviše 16 znakova!\n";
            }
            return povratnaPoruka;
        }

        public static string ProvjeriEmail(string email)
        {
            string povratnaPoruka = "";

            if (new EmailAddressAttribute().IsValid(email) == false)
            {
                povratnaPoruka += "Email nije ispravnog formata!\n";
            }
            if (email == "")
            {
                povratnaPoruka += "Email mora biti unesen!\n";
            }
            return povratnaPoruka;
        }

        public static string ProvjeriBrojcanuVrijednost(string broj)
        {
            string povratnaPoruka = "";
            if (broj.All(Char.IsDigit) == false)
            {
                povratnaPoruka += "Ovo polje mora sadrzavati brojacnu vrijednost!\n";
            }
            if (broj == "")
            {
                povratnaPoruka += "Niste popunili sva polja!\n";
            }
            if (broj.Count() > 11)
            {
                povratnaPoruka += "Brojcana vrijednost ne može imati više od 11 znakova!\n";
            }
            return povratnaPoruka;
        }
        public static string ProvjeriOdabirReda(string red)
        {
            string povratnaPoruka = "";
            if (red =="")
            {
                povratnaPoruka = "Molimo odaberite redak u tablici";
            }
            return povratnaPoruka;
        }

    }
}
