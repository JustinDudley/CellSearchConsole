using System;

namespace CellSearchConsole {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("This world was created for me.\n");
            string[] algArray = { "R'rU2L'U2x'dR2UR2UR2B", "R'UR2Dr'U2rD'R2U'R", "LU'L'U2LRU'L'UR'", "R'DR2DL2D'R2DL2D2R", "UR'U2R'D'RU2R'DR2" };

            // Vary the index below to test:
            var alg = new Alg(algArray[3], "bookAlg", "from the big book");
            //var alg = new Alg("RUR'", "sillyAlg", "this doesn't mean anything really");
            string str = alg.AlgString;


            Console.WriteLine($"The property of the instance alg known as alg.algString is this string: {str}");
            string two = str.Substring(0, 2);
            Console.WriteLine($"Here is a substring: {two}");


            char[] symbolArr = { '\'', '2' };
            string betStr = "";
            for (int i = 0; i < str.Length; i++) {
                betStr += str[i];

                // if neither the current or next character is ' or 2 (mod string.Length performs wraparound to avoid 
                // out-of-bounds, and note: this assumes the first char of string is not ' or 2, which it should never be)
                if(     (!Array.Exists(symbolArr, el => el == str[i])) && (! Array.Exists(symbolArr, el => el == str[(i+1) % str.Length]))     ) {
                    betStr += '1';
                }
            }
            betStr = betStr.Replace('\'', '3');
            

            alg.AlgString = betStr;
            Console.WriteLine($"The property of the instance alg has now been re-defined as new string: {alg.AlgString}");


    
        }
    }
}
