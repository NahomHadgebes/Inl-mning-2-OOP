using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLinlämning
{
    public class Kund
    {
        //ATTRIBUTER FÖR KUND
        public string namn;
        public string ålder;
        public string medlemskap;

        //METODER FÖR KUND
        public virtual void AnvändaRabatt()
        {
            Console.WriteLine("Kunder kan använda bra rabatter som SF bio erbjuder");
        }
        private void UppdateraInfo()
        {
            Console.WriteLine("Kontakt uppgifter krävs varenda gång du bokar film");
        }

    }

        //SUBKLASS
    public class Medlem : Kund
    {
        //ATTRIBUTER FÖR MEDLEM
        public string KöptaFilmBiljett;
        public string medlemskapstyp;
        public string poängsaldo;

        //METODER FÖR KUND
        public new void Uppgradera()
        {
            Console.WriteLine("Medlemskapstyp kan uppgraderas från silver till guld");
        }

        public override void AnvändaRabatt()
        {
            Console.WriteLine("Rabatterna är ännu bättre för medlemmar som får 20% mer än den vanliga kunden");
        }
    }




}
