using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2020_12_08_dolgozat
{

    class Program
    {
        struct Juventus
        {
            public int Mez;
            public string Nev;
            public string Nemzet;
            public string Poszt;
            public int Szulev;

            public Juventus(string sor)
            {
                var t = sor.Split(';');
                Mez = int.Parse(t[0]);
                Nev = t[1];
                Nemzet = t[2];
                Poszt = t[3];
                Szulev = int.Parse(t[4]);
            }
        }
        static void Main(string[] args)
        {
            Beolvasas();
            feladat1();
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            feladat8();
            B_feladat();
            C_feladat();
            Console.ReadKey(true);
        }
        private static void feladat1()
        {

            Console.WriteLine($"Ennyi igazolt játékosa van a csapatnak: {jatekosok.Count()}");
        }
        static List<Juventus> jatekosok = new List<Juventus>();
        private static void Beolvasas()
        {
            StreamReader sr = new StreamReader(@"..\..\Res\juve.txt");
            while (!sr.EndOfStream)
            {
                jatekosok.Add(new Juventus(sr.ReadLine()));
            }
            sr.Close();


            private static void feladat2()
            {
                bool magyar = false;
                foreach (var i in jatekosok)
                {
                    if (i.Nemzet.Contains("Magyar"))
                    {
                        magyar = true;
                    }
                }
                if (magyar)
                {
                    Console.WriteLine("Van Magyar játékos");
                }
                else
                {
                    Console.WriteLine("nincs Magyar játékos");
                }
            }


            private static void feladat3()
            {
                int olasz = 0;
                foreach (var i in jatekosok)
                {
                    if (i.Nemzet == "Olasz")
                    {
                        olasz++;
                    }
                }
                Console.WriteLine($"{olasz} Olasz játékos van a csapatban");
            }


            private static void feladat4()
            {
                
            }


            private static void feladat5()
            {
                int kor = 0;
                foreach (var i in jatekosok)
                {
                    kor += 2020 - i.Szulev;
                }
                Console.WriteLine($"Az átlag életkor: {kor / jatekosok.Count}");
            }


            private static void feladat6()
            {

                var dic = new Dictionary<string, int>();

                foreach (var i in jatekosok)
                {
                    if (!dic.Keys.Contains(i.Poszt))
                    {
                        dic.Add(i.Poszt, 1);
                    }
                    else
                    {
                        dic[i.Poszt]++;
                    }
                }
                foreach (var i in dic)
                {
                    Console.WriteLine($"{i.Key}: {i.Value}");
                }

            }


            private static void feladat7()
            {

            }


            private static void feladat8()
            {
                var dic = new Dictionary<int, int>();
                foreach (var i in jatekosok)
                {
                    if (!dic.Keys.Contains(i.Szulev))
                    {
                        dic.Add(i.Szulev, 1);
                    }
                    else
                    {
                        dic[i.Szulev]++;
                    }
                }
                foreach (var item in dic)
                {
                    if (item.Value == 3)
                    {
                        Console.WriteLine($"{item.Key} évben született 3 játékos");
                    }
                }


            }


            private static void B_feladat()
            {
                Console.WriteLine("Adj meg egy mezszámot ");
                int mezszam = Convert.ToInt32(Console.ReadLine());
                foreach (var i in jatekosok)
                {
                    if (i.Mez == mezszam)
                    {
                        Console.WriteLine($"a {i.Mez} számú mezet {i.Nev} viseli");
                    }
                }
            }


            private static void C_feladat()
        {
            StreamWriter sw = new StreamWriter(@"..\..\Res\hatvedek.txt");
            foreach (var u in jatekosok)
            {
                var f = u.Nev.Split(' ');
                if (u.Poszt == "hátvéd")
                {
                    sw.WriteLine($"{f[1]}\t\t{2020 - u.Szulev}");
                }



            }
            sw.Close();
            Console.WriteLine("fájlbaírás kész");
        }

       
        
        }
    }
}

