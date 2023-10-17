

internal class Program
{
    class Proizvod
    {
        public string? Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        public Proizvod(string? naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"""
                Naziv: {Naziv}
                Cijena: {Cijena}
                Dostupna kolicina: {DostupnaKolicina}
                """);
        }
    }




    class ElektronickiUredjaj
    {
        public string? Naziv { get; set; }
        public string? Proizvodjac { get; set; }
        public int Godina { get; set; }

        public ElektronickiUredjaj(string? naziv, string? proizvodjac, int godina)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            Godina = godina;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"""
                Naziv: {Naziv}
                Proizvodjac: {Proizvodjac}
                Godina: {Godina}
                """);
        }
    }

    class PametniTelefon : ElektronickiUredjaj
    {
        public string? OperativniSustav { get; set; }
        public PametniTelefon(string? naziv, string? proizvodjac, int godina, string? operativniSustav) : base(naziv, proizvodjac, godina)
        {
            OperativniSustav = operativniSustav;
        }
    }

    private static void Main(string[] args)
    {
        Proizvod p = new("Sapun", 23.43m, 23);

        p.IspisiInformacije();

        PametniTelefon pt = new PametniTelefon("14Pro", "Ajfon", 2024, "ajoes");
    }
}