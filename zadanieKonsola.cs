using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsola
{
    public class zadanieKonsola
    {
        public zadanieKonsola()
        {
        }
        public static int liczSamogloski(string slowo)
        {
            int licznikSamo = 0;
            string samoGloski = "AĄEĘIOUÓYaąeęiouóy";
            for (int i = 0; i < samoGloski.Length; i++)
            {
                for (int j = 0; j < slowo.Length; j++)
                {
                    if (slowo[j] == samoGloski[i])
                    {
                        licznikSamo++;
                    }
                }
            }
            return licznikSamo;
        }

        public static int liczZnaki(string slowo, string wzorzec)
        {
            int licznik = 0;
            for (int i = 0; i < slowo.Length; i++)
            {
                for (int j = 0; j < wzorzec.Length; j++)
                {
                    if (wzorzec[j] == slowo[i])
                    {
                        licznik++;
                        break;
                    }

                }
            }
            return licznik;
        }

        public static string usunDupli(string slowo)
        {
            string bezPowtorzen = "";
            for (int i = 0; i<slowo.Length-1; i++)
            {
                
                if (slowo[i] == slowo[i + 1])
                {
                    bezPowtorzen += slowo[i];
                } 

            }
            return bezPowtorzen;
        }

        public static string wspolnyZbiorLiter(string slowo, string slowo2)
        {
            string noweSlowo = "";
            for (int i = 0; i < slowo.Length-1; i++) 
            {
                for(int j = i+1; j < slowo2.Length; j++)
                {
                    if(slowo[i] == slowo2[j])
                    {
                        noweSlowo += slowo[i];
                    }
                }         
            }

            return noweSlowo;
        }
    }

}
