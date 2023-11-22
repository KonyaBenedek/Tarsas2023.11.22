using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        const string fileDob = "dobasok.txt";
        const string fileOsv = "osvenyek.txt";

        static List<string> dobasok = new List<string>();
        static List<string> osvenyek = new List<string>(); 

        static void BeolvasDob(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream) 
            { 
                string[] dobas = sr.ReadLine().Split(' ');
                for (int i = 0; i < dobas.Length; i++)
                {
                    dobasok.Add(dobas[i]);
                }
            }
        }

        static void BeolvasOsv(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);

            while (!sr.EndOfStream) { osvenyek.Add(sr.ReadLine()); }
        }

        static void Main(string[] args) 
        {
            BeolvasDob(fileDob);
            BeolvasOsv(fileOsv);

            Console.WriteLine($"2. feladat \nA dobások száma: {dobasok.Count()} \nAz ösvények száma: {osvenyek.Count()}");

            Console.WriteLine();

            int maxLength = 0;
            int leghoszabbIndex = -1;

            for (int i = 0; i < osvenyek.Count; i++)
            {
                if (osvenyek[i].Length > maxLength)
                {
                    maxLength = osvenyek[i].Length;
                    leghoszabbIndex = i+1;
                }
            }
            if (leghoszabbIndex != -1)
            {
                Console.WriteLine($"3. feladat \nAz egyik leghosszabb a(z) {leghoszabbIndex}. ösvény, hossza: {maxLength} ");
            }

            Console.WriteLine();

            Console.Write("4.feladat \nAdja meg egy ösvény sorszámát! ");
            int osvenySorszam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a játékosok számát! ");
            int jatekosSzam = Convert.ToInt32(Console.ReadLine());

        }
    }
}
