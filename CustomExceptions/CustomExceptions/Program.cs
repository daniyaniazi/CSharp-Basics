using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            CandidateClass c1 = new CandidateClass();
            try
            {
                Console.WriteLine("ENTER AGE : ");
                c1.CandidateAge = Convert.ToInt32(Console.ReadLine());
                ValidateCandidate(c1);

                Console.WriteLine("ENTER NAME : ");
                c1.CandidateName = Console.ReadLine();

                Console.Write("CANDIDATE REGSTGER SUCCESFULYY");
            }
            catch(InvalidCandidate exc)
            {
                Console.WriteLine(exc.Message);
            }
            Console.Read();
        }
        private static void ValidateCandidate(CandidateClass cnd)
        {
            if (cnd.CandidateAge < 18 || cnd.CandidateAge > 60)
                throw new InvalidCandidate(cnd.CandidateAge);
            else
                Console.WriteLine("AGE ACCEPTED");

        }
       
    }
}
