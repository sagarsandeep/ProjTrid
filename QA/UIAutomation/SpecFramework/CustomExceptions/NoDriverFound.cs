using System;

namespace TRID.CustomExceptions
{
   public class NoDriverFound : Exception
    {
        public NoDriverFound(string msg) : base(msg)
        {
            Console.WriteLine("exception");
        }
    }
}
