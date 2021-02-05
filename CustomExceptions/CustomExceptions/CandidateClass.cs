using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class CandidateClass
    {
            public int CandidateAge{ get; set; }
            public string CandidateName { get; set; }
       
    }
    class InvalidCandidate : Exception
    {
        public InvalidCandidate()
        {

        }
        public InvalidCandidate(int age)
            : base("Age limit is from 18 to 60 ! "+age )
        {

        }
    }
}
