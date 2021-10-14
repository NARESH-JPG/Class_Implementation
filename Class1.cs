using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Class_Implementation
{
    partial  class LMS : IAsessment
    {
        string name;
        int SNo;
        long MobileNo;
        string Email;
         public void Display()
        {
            Console.WriteLine("Implementing Void");
        }
        void IAsessment.MCQ_Assesment()
        {
            Console.WriteLine("This implemtation is from LMS Class using assesment INterace");
        } // Defining Methods declared interface 
        void IAsessment.QuestionBank()
        {
            Console.WriteLine(" Returning value from Question bank defined inside LMS Class");
        }    // Defining Methods declared interface 
    }

     partial class LMS :  Placement, IAsessment // Inheritance
    {
        public void Message()
        {
            Console.WriteLine("This message is coming from Seocond implemtation of Class" );
            }

    }

    abstract class Placement// Can't create object of the class
    {
        string Name_Of_Company;
        int No_of_Student_Placed;
        DateTime Year_of_placement;

        public void Placement_record()
        {
            Console.WriteLine("This method will show you complete record of the placement");        
        }
    }

    public interface IAsessment
        { 

            //int Assessment_Count; creating instance field is not allowed
            //Only delaration is allowed inside Interface 
            public void MCQ_Assesment();
             public void QuestionBank();
        

        }
}
