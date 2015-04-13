using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicePolymorphisme
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
    {
        public string Transformation(string text)
        {
            int size = text.Length;
            if (size > 10)
            {
                size = text.Length - 1;
                int size2 = size - 9;

                text = text.Substring(5, size2);

                return text;
            }
            else
            {
                return text;
            }

        }

        public string RemoveVowels(string text)
        {
            string vowels = "aeiouy";
           
            string text1 = new string(text.Where(c => !vowels.Contains(c)).ToArray());
            if (text.Length == 0)
                return text;
           return text1;

         }
             

           

        public string Inverse(string text)
        {
            
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
            
            
            
            
           
        }

        public string Inverse2By2(string text)
        {
             
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
           
            for (int i=0;i<text.Length-1 ;i+=2)
            {
                var temp = cArray[i];
                cArray[i] = cArray[i + 1];
                cArray[i + 1] = temp;
                reverse += cArray[i];
                reverse += cArray[i + 1];
                
            }
           
            return reverse;
           
        }
    }
}

