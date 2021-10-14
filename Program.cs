using System;

namespace Demo_Class_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LMS Akash = new LMS();
            Akash.Display();
            Akash.Message();
            Akash.Placement_record();



            IAsessment Delhi = Akash; // we created refrence of Interface so that it can store refrence of the LMS class object 

            Delhi.MCQ_Assesment();
            Delhi.QuestionBank();
        
    

           // Placement NIT = new Placement();

        }
    }
}
