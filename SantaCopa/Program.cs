using System;
using System.Collections.Generic;
using System.Threading;

namespace SantaCopa
{
    public class Program
    {
        public static List<string> FirstTeam = new List<string>
        {
            "Liverpool","Manchester City","Real Madrid","Bayern de Munique","Barcelona","Paris Saint-Germain","Juventus","Atlético de Madrid","Tottenham Hotspur"
        };

        public static List<string> SecondTeam = new List<string>
        {
            "Manchester United","Internazionale","Chelsea","Sevilla","Borussia Dortmund","Lazio","Napoli","Villarreal","Leicester"
        };

        public static List<string> Players = new List<string>
        {
            "Blog","Brundo","Filipe","Guines","Leo Maia","Michel","Nicolas","Paramore","Pic","Raffo","Virto","Zacca"
        };

        public static List<string> GroupPosition = new List<string>
        {
            "GrupoA1","GrupoA2","GrupoA3","GrupoA4","GrupoB1","GrupoB2","GrupoB3","GrupoB4","GrupoC1","GrupoC2","GrupoC3","GrupoC4"
        };

        public static string dateTimeKey = DateTime.Now.ToString("MM-dd-yyyy_HH:mm*ss.").Replace(":", "h").Replace("*", "m").Replace(".", "s");

        public static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            Console.WriteLine("Aperte alguma tecla para iniciar.");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Chave do sorteio: {dateTimeKey}");
            Console.WriteLine("");
            Console.WriteLine("");            

            Console.WriteLine("=============================================================");
            Console.WriteLine("");
            Console.WriteLine($"Times do primeiro pote: {Helper.ListItems(FirstTeam)}");
            Console.WriteLine("");
            Console.WriteLine("=============================================================");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine($"Times do segundo pote: {Helper.ListItems(SecondTeam)}");
            Console.WriteLine("");
            Console.WriteLine("=============================================================");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine($"Jogadores: {Helper.ListItems(Players)}");
            Console.WriteLine("");
            Console.WriteLine("=============================================================");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("=============================================================");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Aperte alguma tecla iniciar o sorteio.");
            Console.ReadKey();

            Draw draw = new Draw();
            draw.Drawning();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Aperte alguma tecla para encerrar.");
            Console.ReadKey();
        }
    }
}
