using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxMirror
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> sequences = new List<int[]> { 
                new int[] {1, 2, 1, 2, 1},
                new int[] {1, 2, 3, 8, 9, 3, 2, 1},
                new int[] {1, 2, 1, 4},
                new int[] {7, 1, 2, 9, 7, 2, 1},
                new int[] {1,2,3,2,3,2,3,2,3,2}
            };

            GetMaxMirror(sequences);
        }

        static void GetMaxMirror(List<int[]> sequences)
        {
            Console.WriteLine("Get Max Mirror Results from Brute Force Version");
            foreach (var sequence in sequences)
            {
                int maxLength = 1;

                int endIndex = sequence.Length - 1;
                for (int frontIndex = 0; frontIndex < endIndex; frontIndex++)
                {
                    for (int i = endIndex; i > frontIndex; i--)
                    {
                        if (sequence[frontIndex] == sequence[i])
                        {
                            var currentLength = 0;
                            while (frontIndex + currentLength < sequence.Length && i - currentLength >= 0)
                            {
                                if (sequence[frontIndex + currentLength] == sequence[i - currentLength])
                                {
                                    currentLength++;
                                }
                                else break;
                            }
                            if (currentLength > maxLength)
                            {
                                maxLength = currentLength;
                            }
                        }
                    }
                }
                Console.WriteLine("Max length is " + maxLength + " -> Sequence " + (sequences.IndexOf(sequence) + 1));
            }
            Console.WriteLine("End of BruteForce Version");
            Console.ReadLine();
        }

        static void GetMaxMirrorLCS(List<int[]> sequences)
        {

        }
    }
}
