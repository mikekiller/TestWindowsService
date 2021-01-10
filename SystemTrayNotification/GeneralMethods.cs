using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SystemTrayNotification
{
    public static  class GeneralMethods
    {
        
        public static string GetWords(Stack<string> List)
        {
            string result = "";
            foreach (var element in List)
            {
                result += element + " "; 
            }
            return result;

        }
    }
}
