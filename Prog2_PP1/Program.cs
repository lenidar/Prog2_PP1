using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_PP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            string sText = "The template for all modern computers is the Von Neumann architecture, detailed in a 1945 paper by Hungarian mathematician John von Neumann. This describes a design architecture for an electronic digital computer with subdivisions of a processing unit consisting of an arithmetic logic unit and processor registers, a control unit containing an instruction register and program counter, a memory to store both data and instructions, external mass storage, and input and output mechanisms. The meaning of the term has evolved to mean a stored-program computer in which an instruction fetch and a data operation cannot occur at the same time because they share a common bus. This is referred to as the Von Neumann bottleneck and often limits the performance of the system.";
            int[] counter = new int[] { 0, 0, 0, 0, 0 };
            // 0 - word count
            // 1 - sentence count
            // 2 - number count
            // 3 - letter count
            // 4 - other character count

            Console.WriteLine("Please enter the text:");
            text = Console.ReadLine();

            for (int x = 0; x < sText.Length; x++)
            {
                if ((int)sText[x] == 32) // space, end of a word.
                    counter[0]++;

                if ((int)sText[x] == 46 || (int)sText[x] == 33 || (int)sText[x] == 63)
                    counter[1]++;

                if ((int)sText[x] >= 48 && (int)sText[x] <= 57)
                    counter[2]++;
                else if ((int)sText[x] >= 65 && (int)sText[x] <= 90)
                    counter[3]++;
                else if ((int)sText[x] >= 97 && (int)sText[x] <= 122)
                    counter[3]++;
                else
                    counter[4]++;
            }

            counter[0]++;
            // this is necessary without this the last word will not be counted

            Console.WriteLine("Word Count is " + counter[0]);
            Console.WriteLine("Sentence Count is " + counter[1]);
            Console.WriteLine("Number Count is " + counter[2]);
            Console.WriteLine("Letter Count is " + counter[3]);
            Console.WriteLine("Special Character Count is " + counter[4]);

            Console.ReadKey();
        }
    }
}
