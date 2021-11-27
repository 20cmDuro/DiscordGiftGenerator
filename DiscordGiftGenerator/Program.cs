using System;

namespace DiscordGiftGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Utils utils = new Utils();
            int quantia;
            StreamWriter sw = File.AppendText("./gifts.txt");
            Console.WriteLine("<--|   Gerador de Gifts Discord   |-->\n<--|  https://github.com/20cmDuro |-->");
            Console.Write("Quantia: ");
            quantia = int.Parse(Console.ReadLine());
            for(int i = 0; i != quantia; i++) {
                sw.WriteLine(utils.gen_gift());
            }
            sw.Close();
            Console.WriteLine($"Gifts gerados com sucesso!\nOs Gifts foram salvos em 'gifts.txt'.");
            Console.ReadKey();
        }
    }
}