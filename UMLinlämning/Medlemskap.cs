using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLinlämning;

namespace UMLinlämning
{
    class Medlemskap
    {
        //ATTRIBUTER FÖR MEDLEMSKAP
        public string KöptaFilmBiljett;
        public string medlemskapstyp;
        public string poängsaldo;

        //METODER FÖR MEDLEMSKAP
        public void Uppgradera()
        {
            Console.WriteLine("Medlemskapstyp kan uppgraderas från silver till guld");
        }

        public void AnvändRabatt()
        {
            Console.WriteLine("Förmåner med medlemskap är att du får rabatter som du kan andvända när du vill");
        }


}   }
