using System;
using System.IO;

namespace MyDemoWebApp
{
    public class NumberCompare
    {

        public bool GreaterThanZero(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                throw new
                    ArgumentNullException("fileName");
            }
            return Int64.Parse(number) > 0;
        }
    }
}
