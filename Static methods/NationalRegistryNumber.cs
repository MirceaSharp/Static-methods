using System;

namespace Static_methods
{
    class NationalRegistryNumber
    {





        public static bool IsValid(string rrnr)
        {
            if (rrnr.Length == 11)
            {
                int first9 = Convert.ToInt32(rrnr.Substring(0, 9));
                int moduloResult = first9 % 97;
                int finalResult = 97 - moduloResult;
                int controlNumber = Convert.ToInt32(rrnr.Substring(9));
                if (finalResult == controlNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            return true || false;
        }

    }
}
