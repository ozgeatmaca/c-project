using System;
using System.Collections.Generic;
using System.Linq;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            Ogrenci ogrenci2 = new Ogrenci();
            Ogrenci ogrenci3 = new Ogrenci();
            ogrenci1.OgrenciKayit();
            ogrenci1.Hesapla(ogrenci1.Ders, ogrenci1.DersNotlari, ogrenci1.BasariNotu);
            ogrenci1.OgrenciYazdir();
            ogrenci2.OgrenciKayit();
            ogrenci2.Hesapla(ogrenci2.Ders, ogrenci2.DersNotlari, ogrenci2.BasariNotu);
            ogrenci2.OgrenciYazdir();
            ogrenci3.OgrenciKayit();
            ogrenci3.Hesapla(ogrenci3.Ders, ogrenci3.DersNotlari, ogrenci3.BasariNotu);
            ogrenci3.OgrenciYazdir();
        }
    }

    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string Cinsiyet { get; set; }
        public double BasariNotu;
        public List<string> Ders;
        public List<double> DersNotlari;

        public Ogrenci()
        {
            Ders = new List<string>(3);
            DersNotlari = new List<double>(2);
        }

        public Ogrenci(List<string> _Ders)
        {
            Ders = _Ders;
            string Ders1 = Ders[0];
            string Ders2 = Ders[1];
            string Ders3 = Ders[2];
        }

        ~Ogrenci()
        {
            Ders = new List<string>();
            DersNotlari = new List<double>();
        }

        public void Hesapla(List<string> _Ders, List<double> _DersNotlari, double _BasariNotu)
        {
            Ders = _Ders;
            BasariNotu = _BasariNotu;
            DersNotlari = _DersNotlari;
            
            BasariNotu = (DersNotlari[0]*40)+(DersNotlari[1]*60);
            
            Console.WriteLine(Ders[0] + ": " + BasariNotu + " Almışsınız");

        }
        public void OgrenciKayit()
        {
            Console.WriteLine("Lütfen öğrencinin adını giriniz.");
            Ad = Console.ReadLine();
            Console.WriteLine("Lütfen öğrencinin soyadını giriniz.");
            Soyad = Console.ReadLine();
            Console.WriteLine("Lütfen öğrencinin TC nosunu giriniz.");
            TcNo = Console.ReadLine();
            Console.WriteLine("Lütfen öğrencinin cinsiyetini giriniz.");
            Cinsiyet = Console.ReadLine();
            Console.WriteLine("Lütfen öğrencinin aldığı dersleri giriniz.");
            Console.Write("Ders1: "); Ders.Add(Console.ReadLine());
            Console.Write("Ders2: "); Ders.Add(Console.ReadLine());
            Console.Write("Ders3: "); Ders.Add(Console.ReadLine());
            Console.WriteLine("Lütfen öğrencinin aldığı "+Ders[0]+" notlarını giriniz.");
            Console.Write("Vize: "); DersNotlari.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Final: "); DersNotlari.Add(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Lütfen öğrencinin aldığı " + Ders[1] + " notlarını giriniz.");
            Console.Write("Vize: "); DersNotlari.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Final: "); DersNotlari.Add(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Lütfen öğrencinin aldığı " + Ders[2] + " notlarını giriniz.");
            Console.Write("Vize: "); DersNotlari.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Final: "); DersNotlari.Add(Convert.ToDouble(Console.ReadLine()));
        }
        public void OgrenciYazdir()
        {
            Console.WriteLine("Adı: " + Ad);
            Console.WriteLine("Soyadı: " + Soyad);
            Console.WriteLine("TC No: " + TcNo);
            Console.WriteLine("Cinsiyet: " + Cinsiyet);
            Console.WriteLine(Ders[0]+": " + BasariNotu);
            Console.WriteLine(Ders[1] + ": " + BasariNotu);
            Console.WriteLine(Ders[2] + ": " + BasariNotu);
        }
    }
}