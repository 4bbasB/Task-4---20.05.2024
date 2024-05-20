using System.Security.Cryptography;
using System.Xml.Linq;

namespace Task_5___20._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Bir int parametr qəbul edən və o ədədə qədər bütün cüt ədədlərin cəmini ekrana yazdıran, həm return type - ı olan bir method, həm də void bir method yazırsız
            //2.Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.Misal olaraq, name = "  Code  Acacemy   " deyə bir variable - mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "CodeAcademy" olmalıdır.
            //3.İstənilən verilən cümlədə sözlərin baş hərflərini ekrana yazdıran method yazın məs .("Hello World --> "H" "W" )

            #region Task 1
            //Console.Write("Ededi yazin: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Edede qeder olan cut ededlerin cemi: " + SumOfEvens(number));
            //sumOfEvens(number);
            #endregion

            #region Task 2
            //string name = "  Code  Acacemy   ";
            //DeleteSpaces(name);
            #endregion

            #region Task 3
            //Console.Write("Bir cumle daxil edin: ");
            //string word = Console.ReadLine();
            //FirstLetters(word);
            #endregion
        }


        #region Task 1
        static int SumOfEvens(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if(i % 2 == 0)
                    sum += i;
            }

            return sum;
        }
        static void sumOfEvens(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }

            Console.WriteLine("Edede qeder olan cut ededlerin cemi: " + sum);
        }
        #endregion

        #region Task 2
        static void DeleteSpaces(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ' ')
                    Console.Write(name[i]);
            }
        }
        #endregion

        #region Task 3
        static void FirstLetters(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0)
                    Console.WriteLine(word[i]);

                else if (word[i] == ' ')
                    Console.WriteLine(word[i + 1]);
            }
        }
        #endregion



    }
}