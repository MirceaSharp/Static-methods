﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_methods
{
    class LeapYear
    {

         public static bool IsLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                return true;
            }
            else
            { 
                return false;

            }
            
        }
          
      
    }
}
