using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tema_SET_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MENU();

                //N_CHECK();

                int n;
                Console.WriteLine();
                Console.WriteLine("Daca vreti sa iesiti din aplicatie introduceti 0.");
                Console.Write("Introduceti numarul exercitiului dorit:");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {

                    case 1: P1(); break;
                    case 2: P2(); break;
                    case 3: P3(); break;
                    case 4: P4(); break;
                    case 5: P5(); break;
                    case 6: P6(); break;
                    case 7: P7(); break;
                    case 8: P8(); break;
                    case 9: P9(); break;
                    case 10: P10(); break;
                    case 11: P11(); break;
                    case 12: P12(); break;
                    case 13: P13(); break;                                        
                    case 14: P14();
                        Intoarecere();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 15: P15();
                        Intoarecere();
                        Console.ReadKey();
                        Console.Clear(); 
                        break;
                    //case 16: P16();
                        Intoarecere();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    //case 17: P17();
                        Intoarecere();
                        Console.ReadKey();
                        Console.Clear(); break;
                    case 0: return;
                    default: Console.WriteLine("Numar introdus gresit"); break;
                }
            }
        }
        private static void MENU()
        {
            Console.WriteLine("1.Se da o secventa de n numere. Sa se determine cate din ele sunt pare. \r\n2.Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. \r\n3.Calculati suma si produsul numerelor de la 1 la n. \r\n4.Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. \r\n5.Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. \r\n6.Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. \r\n7.Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. \r\n8.Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...\r\n9.Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. \r\n10.Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. \r\n11.Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. \r\n12.Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. \r\n13.O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. \r\n14.O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. \r\n15.O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. \r\n16.O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. \r\n17.Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. \r\n");

        }

        /// <summary>
        /// Cate numere sunt pare din secventa.
        /// </summary>
        private static void P1()
        {
            Console.WriteLine("1.Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");

            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n =uint.Parse(Console.ReadLine());
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int count = 0;
            
            
                for (int i = 0; i < n; i++)
                {
                    int a;
                    a = int.Parse(Console.ReadLine());
                    if (a % 2 == 0) count++;
                }
            Console.WriteLine($"In secventa data sunt {count} numere pozitive.");
            Intoarecere();
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Cate numere sunt negative,zero,pare din secventa.
        /// </summary>
        private static void P2()
        {
            Console.WriteLine("2.Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");

            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int countzero = 0;
            int countneg = 0;
            int countpoz = 0;
            for (int i = 0; i < n; i++)
            {
                int a;
                a = int.Parse(Console.ReadLine());
                if (a > 0) countpoz++;
                if(a < 0) countneg++;
                if (a == 0) countzero++;

            }
            Console.WriteLine($"In secventa data sunt:numere negative:{countneg},numere zero:{ countzero},numere pozitive:{countpoz}.");
            Intoarecere();
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Calculam suma si produsul numerelor de la 1 la n.
        /// </summary>
        private static void P3()
        {
            Console.WriteLine("3.Calculati suma si produsul numerelor de la 1 la n. ");
            int n;
            Console.Write("Introduceti n:");
            n=int.Parse(Console.ReadLine());
            int suma = (n * (n + 1)) / 2;
            int p=1;
            for (int i = 2; i <= n; i++)
            {
                p *= i;  //produsul functioneaza pana la 12,dupa apare eroare
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este:{suma}.");
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este:{p}.");
           Intoarecere();
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Determinam pe ce pozitie se afla numarul a.
        /// </summary>
        private static void P4()
        {
            Console.WriteLine("4.Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. ");
             Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            Console.Write("Introduceti numarul a:");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int count = -1;
            int pozitie = -1;
            for (int i = 0; i < n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
               count++;
                if(a==x)
                {
                    pozitie=count; 
                }

            }
            Console.WriteLine($"Numarul {a} se afla in secventa pe pozitia:{pozitie}.");
            Intoarecere();
            Console.ReadKey() ;
            Console.Clear();
        }
        /// <summary>
        /// Elemente egale cu pozitia pe care apar. 
        /// </summary>
        private static void P5()
        {
            Console.WriteLine("5.Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. \r\n");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            int count = 0;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            for (int i = 0; i < n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
               if(x==i)count++;

            }
            Console.WriteLine($"In secventa numerele egale cu pozitia pe care apar este:{count}");
            Intoarecere();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Determinam daca numerele din secventa sunt ordine crescatoare.
        /// </summary>
        //TODO fal sa functioneze
        private static void P6()
        {
            Console.WriteLine("6.Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            int cresc = 1;
            int y = Int32.MinValue;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            for (int i = 0; i < n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
                
                if (y > x) cresc = 0;
                y= x;
                
            }
            if (cresc == 1) Console.WriteLine("Secventa este crescatoare.");
            else Console.WriteLine("Secventa nu este crescatoare.");
            Intoarecere();
            Console.ReadKey();
            Console.Clear();

        }
        /// <summary>
        /// Determinam cea mai mica si cea mai mare valoare din secventa.
        /// </summary>
        private static void P7()
        {
         Console.WriteLine("7.Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            int max = Int32.MinValue, min = Int32.MaxValue;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            for (int i = 0; i < n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
                if (x > max)
                {
                    max = x; 
                }
                if (x < min)
                {
                    min = x; 
                }

            }
            Console.WriteLine($"Cea mai mica valoare din secventa este:{min},cea mai mare valoare din secventa este:{max}." );
            Intoarecere();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Determinan al n-lea numar din sirul lui Fibonacci.
        /// </summary>
        private static void P8()
        {
            Console.WriteLine("8.Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
            int n;
            Console.Write("Introduceti n:");
            n=int.Parse(Console.ReadLine());
            int nr0,nr1,nr;
            nr0 = 0; nr1=1; nr=1;
            if (n == 1)
            {
                Console.WriteLine("Primul termen din sirul lui Fibonacci este 0.");
                Console.ReadKey();
                return;
                
            }
            for (int i = 3; i <= n; i++)
            {
                nr = nr0 + nr1;
                nr0 = nr1;
                nr1 = nr;
            }
            Console.WriteLine($"\nAl {n}-lea termen din sirul lui Fibonacci este: {nr}");
            Intoarecere();
            Console.ReadKey();
            Console.Clear();

        }
        /// <summary>
        /// Determinam daca o secventa este monotona.
        /// </summary>
        private static void P9()
        {
          Console.WriteLine("9.Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. \r\n");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            int cresc = 1;
            int y=Int32.MinValue;
            int desc = 1;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            for (int i = 0; i < n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
                if (i!=0)
                {
                    if (y > x) cresc = 0;
                    if (x > y) desc = 0;
                }    
                y = x;
                    
               
            }
            if (cresc == 1 &&  desc==1||cresc==1&&desc==0||cresc==0&&desc==1)            
                Console.WriteLine("Secventa este monotona.");
            else
                Console.WriteLine("Secventa nu este monotona.");
            Intoarecere();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Numarul maxim de numere consecutive egale din secventa.
        /// </summary>
        private static void P10()
        {
            Console.WriteLine("10.Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. \r\n");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            int countegal = 0, max = 0, countaux = 0, st = 0;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            for (int i = 0; i < n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    st = x;
                    continue;
                }
                if (x == st)
                {
                    countegal++;
                    max = countegal;
                    if (countaux < max)
                    {
                        countaux = max;
                    }
                }
                if (x != st)
                {
                    countegal = 0;
                }
                st = x;
            }
            Console.WriteLine($"Maximul de numere consecutive egale din secventa este: {countaux + 1}.");
            Intoarecere();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Suma inverselor numerelor din secventa.
        /// </summary>
        private static void P11()
        {
            Console.WriteLine("11.Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. \r\n");
            Console.Write("Introduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            int s = 0;
            Console.WriteLine("Introduceti secventa de numere:");
            for (int i = 0; i < n; i++)
            {
                int x;int invers = 0;
                x = int.Parse(Console.ReadLine());
                while (x != 0)
                {
                    invers = invers * 10 + x % 10;
                    x /= 10;
                }
                s += invers;
            }
            Console.WriteLine($"Suma inverselor din secventa este egala cu:{s}");
            Intoarecere();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Grupuri de numere consecutive intr-o secventa. 
        /// </summary>
        private static void P12()
        {
            Console.WriteLine("12.Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. ");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            int count = 1;int count2 = 0;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            for (int i = 0; i < n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
                if (x != 0) count2++;
                if (x == 0 && count2 != 0)
                {
                     count++;
                    count2 = 0;
                }      
                if(i==n-1)
                {
                    if (x == 0)
                        count--;
                }     
            }
            Console.WriteLine("In secventa sunt "+count+" grupuri de numere consecutive diferite de zero.");
            Intoarecere();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Determinam daca o secventa este crescatoare rotita.
        /// </summary>
        private static void P13()
        {
            Console.WriteLine("O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            bool cerinta = true;
            bool rotit = false;
            int secv1 = 0;
            int secv2 = 0;
            {
                int  nr = Int32.MinValue;
                for (int i = 0; i < n; i++)
                {
                    int x;
                    x = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        secv1 = x;
                    }
                    if (i == n - 1)
                    {
                        secv2 = x;
                    }
                    if (rotit)
                    {
                        if (nr > x)
                        {
                            cerinta = false;
                        }
                    }
                    if (nr > x)
                    {
                        rotit = true;
                    }
                    nr = x;
                }
                if (rotit)
                {
                    if (secv1 < secv2)
                    {
                        Console.WriteLine("Secventa nu este o secventa crescatoare rotita.");
                        return;
                    }
                }
                if (cerinta)
                {
                    Console.WriteLine("Secventa este o secventa crescatoare rotita.");
                }
                else Console.WriteLine("Secventa nu este o secventa crescatoare rotita.");
            }
            Intoarecere();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Determinam daca o secventa este monotona rotita.
        /// </summary>
        //TODO nu functioneaza corect
        private static void P14()
        {
            Console.WriteLine("14.O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. ");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            int cresc = 0;int desc = 0;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int nr = int.MaxValue;
            int start = 0;int end = 0;
            for (int i = 0; i < n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    nr = x;
                    start = x;
                }
                if (i == n - 1)
                {
                    end = x;
                }
                if (x > nr) cresc++;
                if (x < nr) desc++;
                nr = x;
            }
            if (cresc == 0 || desc == 0)
            {
                    Console.WriteLine("Secventa este monotona rotita.");
                return;
            }           
            if (cresc < 2 && desc < 2) // orice secventa de 3 elemente poate fi rotita sa formeze una monotona.
            {
                Console.WriteLine("Secventa este monotona rotita.");
                return;
            }
            if (desc < 2 && cresc > 2) // secventa crescatoare
            {
                if (start > end)
                {
                    Console.WriteLine("Secventa este monotona rotita.");
                    return;  
                } 
            }     
            if (cresc < 2 && desc > 2) // secventa descrescatoare
            {
                if (start < end)
                {
                    Console.WriteLine("Secventa este monotona rotita.");
                    return;                
                }
            }            
              Console.WriteLine("Secventa nu este monotona rotita.");
            
            //Console.WriteLine($"C: {cresc}, D: {desc}"); 
           
        }
        /// <summary>
        /// Determinam daca o secventa este bitonica.
        /// </summary>
        private static void P15()
        {
            Console.WriteLine("15.O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica.");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            bool bitonic = false;
            bool cresc = false;
            int a, inr = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (!bitonic) // prima data ii crescatore, verifica pana cand secventa descreste.
                {
                    a = int.Parse(Console.ReadLine());
                    if (i > 0 && a > inr) // trebuie sa fie crescator minim odata.
                    {
                        cresc = true;
                    }
                    if (inr > a)
                    {
                        bitonic = true;
                        continue;
                    }
                    inr = a;
                }
                if (bitonic)
                {
                    a = int.Parse(Console.ReadLine());
                    if (inr < a)
                    {
                        bitonic = false;
                    }
                    inr = a;
                }
            }
            if (bitonic && cresc)
            {
                Console.WriteLine("Secventa este bitonica.");
                return;
            }
            Console.WriteLine("Secventa nu este bitonica.");
        }
        /// <summary>
        /// Determinam daca o secventa este bitonica rotita.
        /// </summary>
        private static void P16()
        {
            Console.WriteLine("16.O <secventa bitonica rotita> este o secventa bitonica sau una care poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int valcresc = 0;
            int valdesc = 0;
            bool bitonic = true;
            bool rotit = false;
            bool crescmax1 = false;
            bool descmax1 = false;
            int endsec = 0, startsec = 0;
            int prevnr = 0;

            for (int i = 0; i < n; i++)
            {
                int a;
                a = int.Parse(Console.ReadLine());
                if (!bitonic)
                {
                    continue;
                }
                if (i == 0) 
                {
                    prevnr = a;
                    startsec = a;
                }
                if (i == n - 1) 
                {
                    endsec = a;
                }
                if (valcresc > 1 || valdesc > 1) 
                {
                    rotit = true;
                }
                if (valcresc >= 1 && valdesc >= 1) 
                {
                    if (crescmax1) 
                    {
                        if (a < prevnr)
                        {
                            valdesc = 2;
                            prevnr = a;
                            continue;
                        }
                        if (a > prevnr)
                        {
                            if (valdesc == 2)
                            {
                                bitonic = false;
                                continue;
                            }
                            prevnr = a;
                            continue;
                        }
                    }
                    if (descmax1) 
                    {
                        if (a > prevnr)
                        {
                            valcresc = 2;
                            prevnr = a;
                            continue;
                        }
                        if (a < prevnr)
                        {
                            if (valcresc == 2)
                            {
                                bitonic = false;
                                continue;
                            }
                            prevnr = a;
                            continue;
                        }
                    }
                }
                if (a > prevnr)
                {
                    if (valdesc == 1) 
                    {
                        crescmax1 = true;
                    }
                    valcresc = 1;
                }
                if (a < prevnr)
                {
                    if (valcresc == 1) 
                    {
                        descmax1 = true;
                    }
                    valdesc = 1;
                }
                prevnr = a;
            }
            if (rotit) 
            {
                if (crescmax1)
                {
                    if (startsec > endsec)
                    {
                        bitonic = false;
                    }
                }
                if (descmax1)
                {
                    if (startsec < endsec)
                    {
                        bitonic = false;
                    }
                }
            }
            if (!bitonic)
            {
                Console.WriteLine("Secventa nu este bitonica rotita.");
                return;
            }
            Console.WriteLine("Secventa este bitonica rotita.");
        }
        /// <summary>
        /// Determinam gradul de incuibare.      
        /// </summary>
        private static void P17()
        {
            Console.WriteLine("17.Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. \r\n");
            Console.Write("\nIntroduceti lungimea secventei (n): ");
            uint n = uint.Parse(Console.ReadLine());
            if (n == 0) return;
            Console.WriteLine("\nIntroduceti secventa de numere:");
            int countr = 0; // paranteze deschise
            int countd = 0; // paranteze inchise
            int incuib = 1;
            int incuibaux1 = 0;
            int incuibaux2 = 1;
            bool cerinta = true;

            for (int i = 0; i < n; i++)
            {
                int a;
                a = int.Parse(Console.ReadLine());
                if (a < 0 || a > 1)
                {
                    Console.WriteLine("Secventa poate contine doar 0-uri si 1-uri!!!");
                    return;
                }
                if (i == 0)
                {
                    if (a == 1)
                    {
                        cerinta = false;
                    }
                }
                if (a == 0)
                {
                    countr++;
                    incuibaux1++;
                }
                if (a == 1)
                {
                    countd++;
                    incuibaux1--;
                }
                if (incuibaux1 > 0 && a == 0)
                {
                    incuib = incuibaux1;
                    if (incuibaux2 < incuib)
                    {
                        incuibaux2 = incuib;
                    }
                }
                if (incuibaux1 == 0) incuib = 0;
            }
            if (countr != countd || !cerinta)
            {
                Console.WriteLine("Secventa introdusa este incorecta.");
                return;
            }
            Console.WriteLine($"Secventa introdusa este corecta si are nivelul maxim de incuibare {incuibaux2}."); 
            return;        
           
        }
        private static void Intoarecere()
        {
            Console.WriteLine("Apasa orice buton pentru a reveni la meniu.\n");
        }

    }
}
