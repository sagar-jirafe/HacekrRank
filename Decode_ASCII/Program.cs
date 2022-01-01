using System;

namespace Decode_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedASCII = "23511011501782351112179911801562340161171141148";
            
            //Reverse String
            char[] encodedASCIIArray = encodedASCII.ToCharArray();
            Array.Reverse(encodedASCIIArray);
            string reverseEncodedASCII = new string(encodedASCIIArray);
            string input = reverseEncodedASCII;

            string result = "";

            while(input.Length > 0)
            {
                int code = int.Parse(input.Substring(0, 2));

                if (code < 32 && input.Length >= 3)
                {
                    code = int.Parse(input.Substring(0, 3));
                }

                if ((code >= 65 && code <= 90) || (code >= 97 && code <= 122) || code == 32){
                    result += (Convert.ToChar(code)).ToString();
                }

                input = input.Substring(code.ToString().Length, input.Length - code.ToString().Length);

            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
