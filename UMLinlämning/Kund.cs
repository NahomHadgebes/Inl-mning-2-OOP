using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLinlämning
{
    internal class Kund
    {
        //ATTRIBUTER FÖR KUND
        public string namn;
        public string ålder;
        public string medlemskap;

        //METODER FÖR KUND
        private void starta()
        {
            Console.WriteLine("Kunder kan starta upp ett kundkonto för att börja samla poäng");
        }
        private void UppdateraInfo()
        {
            Console.WriteLine("Kontakt uppgifter krävs varenda gång du bokar film");
        }



    }
}