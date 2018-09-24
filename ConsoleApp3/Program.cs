using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneticAlphabet {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Vul het woord in");
            var s = Console.ReadLine();

            var array = new String[] { "alpha",
                                       "bravo",
                                       "charlie",
                                       "delta",
                                       "echo",
                                       "foxtrot",
                                       "golf",
                                       "hotel",
                                       "india",
                                       "julliet",
                                       "kilo",
                                       "lima",
                                       "mike",
                                       "november",
                                       "oscar",
                                       "papa",
                                       "quebec",
                                       "romeo",
                                       "sierra",
                                       "tango",
                                       "uniform",
                                       "victor",
                                       "whiskey",
                                       "x-ray",
                                       "yankee",
                                       "zulu",
                                       "Zero",
                                       "One",
                                       "Two",
                                       "Three",
                                       "Four",
                                       "Five",
                                       "Six",
                                       "Seven",
                                       "Eight",
                                       "Nine"};

            var word = s.ToArray();
            var output = "CharToName: ";
            var arrayOutput = "Array: ";

            for(int i = 0; i < word.Length; i++) {
                if(char.IsLower(word[i])) {
                    //output += CharToName(word[i]) + " ";
                    arrayOutput += array[(int)word[i] - 97] + " ";
                } else if(char.IsUpper(word[i])) {
                    //output += CharToName(word[i]).ToUpper() + " ";
                    arrayOutput += array[(int)word[i] - 65].ToUpper() + " ";
                } else if(char.IsNumber(word[i])){
                    arrayOutput += array[(int)word[i] - 48 + 26] + " ";
                } else {
                    arrayOutput += word[i] + " ";
                }

            }

            Console.WriteLine(arrayOutput);
            Console.WriteLine(output);

        }

        public static string CharToName(char character) {
            switch(character) {
                case 'a':
                case 'A':
                    return "alpha";
                case 'b':
                case 'B':
                    return "bravo";
                case 'c':
                case 'C':
                    return "charlie";
                case 'd':
                case 'D':
                    return "delta";
                case 'e':
                case 'E':
                    return "echo";
                case 'f':
                case 'F':
                    return "foxtrot";
                case 'g':
                case 'G':
                    return "golf";
                case 'h':
                case 'H':
                    return "hotel";
            }
            return character.ToString();
        }

    }
}
