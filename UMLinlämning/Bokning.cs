using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UMLinlämning
{
    internal class Bokning
    {
        //ATTRIBUTER FÖR BOKNING
        public string bokningID;
        public string name;
        public string datum;

        //METODER FÖR BOKNING
        public void Skapa()
        {
            Console.WriteLine("Boka filmbiljjeter genom att andvända funktionen boka");
        }
        
        public void Avboka()
        {
            Console.WriteLine("Avboka filmbiljett genom att andvända funktionen avboka");
        }
    
        public void Bekräfta()
        {
            Console.WriteLine("Bekräftning av bokning krävs för att boknningen ska kunna gå igenom");
        }
    


    }   
}
