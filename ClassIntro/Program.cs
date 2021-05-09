using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
    {
        string adi = "Şeyma";
        int yas = 21;

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmeni = "Engin Demirog";
        kurs1.IzlenmeOrani = 66;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Python";
        kurs2.Egitmeni = "Berkay Bilgin";
        kurs2.IzlenmeOrani = 78;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Java";
        kurs3.Egitmeni = "Kerem Varış";
        kurs3.IzlenmeOrani = 42;

        //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni);

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

        foreach (Kurs kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni + "   %" + kurs.IzlenmeOrani);
        }

    }
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmeni { get; set; }
    public int IzlenmeOrani { get; set; }
}

}
