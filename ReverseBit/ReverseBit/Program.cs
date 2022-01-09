using System;

namespace ReverseBit
{
    class Program
    {
        static byte[] ByteArray = { 2,3,5,1,6};
        //bKey
        static void Main(string[] args)
        {
            //Console.WriteLine("Ведите значения массива типа Байт. что бы закончить ввод нажмите 'ESC'");
            Console.WriteLine("Массив будет выполняет битовый реверс каждого байта в массиве и выводит результат на экран.");
            Console.WriteLine("Массив для обработки: 2,3,5,1,6");
            Console.WriteLine("Нажмите 'ENTER' для продолжения");
            Console.ReadLine();
            command.main(ByteArray);
            for (int i = 0; i < ByteArray.Length; i++)
            {
                Console.Write($"{ByteArray[i]}  ") ;
            }
        }
    }
}
