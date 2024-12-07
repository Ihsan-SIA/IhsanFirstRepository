using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_practice
{
    internal class GetVowelPositions
    {

        public static void VowelPosition(string aStringS)
        {
            aStringS = aStringS.ToLower();
            int posLength = 0;
            int positionsIndex = 0;
            int[] positions = new int[posLength];
            char[] vowelCharacters = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            for (int aStringsIndex = 0; aStringsIndex < aStringS.Length; aStringsIndex++)
            {
                for (int indexVowels = 0; indexVowels < vowelCharacters.Length; indexVowels++)
                {
                    if (aStringS[aStringsIndex] == vowelCharacters[indexVowels])
                    {
                        posLength++;
                         Array.Resize(ref positions, positions.Length +1);
                        positions[positionsIndex] = aStringsIndex;
                        positionsIndex++;
                        break;
                    }
                    //positions[j] = aStringS.IndexOf(vowelCharacters[j]);
                    //stringCharacters[indexVowel] = aStringS.IndexOf(vowelCharacters[j]);
                }
            }
            foreach (int item in positions)
            {
                Console.Write(item);
                if (posLength == 1) break;
                else
                {
                    Console.Write(", ");
                    posLength--;
                }    
                Console.Write(", ");
            }
            //Console.Write('[');
            //foreach (var item in positions)
            //{
            //    Console.Write(item);
            //    if (lenArgument == 1) break;
            //    else
            //    {
            //        Console.Write(", ");
            //        lenArgument--;
            //    }
            //    Console.WriteLine(']');
            //}
            //Console.Write('[');
            //foreach (int contentIndexVowel in stringCharacters)
            //{
            //    Console.Write(contentIndexVowel);
            //    if (strLength == 1) break;
            //    else
            //    {
            //        Console.Write(", ");
            //        strLength--;
            //    }
            //}
            //Console.Write(']');
        }
    public static void VowelPosition2(string aStringS)
        {
            aStringS = aStringS.ToLower();
            int posLength = 0;
            int positionsIndex = 0;
            int[] positions = new int[posLength];
            char[] vowelCharacters = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            for (int aStringsIndex = 0; aStringsIndex < aStringS.Length; aStringsIndex++)
            {
                /*for (int indexVowels = 0; indexVowels < vowelCharacters.Length; indexVowels++)
                {
                    if (aStringS[aStringsIndex] == vowelCharacters[indexVowels])
                    {
                        posLength++;
                         Array.Resize(ref positions, positions.Length +1);
                        positions[positionsIndex] = aStringsIndex;
                        positionsIndex++;
                        break;
                    }
                    //positions[j] = aStringS.IndexOf(vowelCharacters[j]);
                    //stringCharacters[indexVowel] = aStringS.IndexOf(vowelCharacters[j]);
                }
            */


                if (vowelCharacters.Contains(aStringS[aStringsIndex]))
                {
                  //  posLength++;
                    Array.Resize(ref positions, positions.Length + 1);
                    positions[positionsIndex] = aStringS.IndexOf(aStringS[aStringsIndex]);
                    positionsIndex++;
                }
            }
            foreach (int item in positions)
            {
                Console.Write(item);
                Console.Write(", ");
            }
            //Console.Write('[');
            //foreach (var item in positions)
            //{
            //    Console.Write(item);
            //    if (lenArgument == 1) break;
            //    else
            //    {
            //        Console.Write(", ");
            //        lenArgument--;
            //    }
            //    Console.WriteLine(']');
            //}
            //Console.Write('[');
            //foreach (int contentIndexVowel in stringCharacters)
            //{
            //    Console.Write(contentIndexVowel);
            //    if (strLength == 1) break;
            //    else
            //    {
            //        Console.Write(", ");
            //        strLength--;
            //    }
            //}
            //Console.Write(']');
        }
    
    
    }
}
