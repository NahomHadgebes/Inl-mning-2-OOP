using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLinlämning
{
    internal class Filmbiljett
    {
        //ATTRIBUTER FÖR FILMBILJETT
        public string BiljettID;
        public string streckkod;

        //METODER FÖR FILMBILJETT
        public void Skanna()
        {
            Console.WriteLine("För att kunna andvända filmbiljetter behöver den skannas i salongen");
        }
    
        public void UppdateraSittplats()
        {
            Console.WriteLine("Du har möjligheten att byta sittplatser när du skannar din filmbiljett");
        }
    
    
    }
}
