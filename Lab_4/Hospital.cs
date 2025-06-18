using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.(A) Create a class Hospital with HospitalDetails() method.Create another classes Apollo, Wockhardt, Gokul_Superspeciality which 
//overrides HospitalDetails() method.
namespace Lab_4
{
    class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("Hospital Details: General Hospital");
        }
    }
    class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Hospital Details: Apollo Hospital");
        }
    }
    class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Hospital Details: Wockhardt Hospital");
        }
    }
    class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Hospital Details: Gokul Superspeciality Hospital");
        }
    }
}
