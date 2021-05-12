using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace SantaCopa
{
    public class PlayerTeam
    {
        public string FirstTeam { get; set; }
        public string SecondTeam { get; set; }
        public string Player { get; set; }
        public string GroupPosition { get; set; }
    }

    

    public class Draw
    {
        List<string> PlayerTeamFinal = new List<string>();
        List<string> firstTeam = Program.FirstTeam;
        List<string> secondTeam = Program.SecondTeam;
        List<string> players = Program.Players;
        List<string> groups = Program.GroupPosition;

        public PlayerTeam Drawning()
        {
            Random random = new Random();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     INICIANDO SORTEIO");
            Console.WriteLine();
            Console.WriteLine();
            Spin();
            int counter = 1;

            string firstRandomTeam = string.Empty;
            string secondRandomTeam = string.Empty;
            string playerRandom = string.Empty;
            string groupRandom = string.Empty;

            string firstRandomTeamA = string.Empty;
            string firstRandomTeamB = string.Empty;
            string firstRandomTeamC = string.Empty;

            string secondRandomTeamA = string.Empty;
            string secondRandomTeamB  = string.Empty;
            string secondRandomTeamC = string.Empty;

            foreach (var player in players.ToList())
            {
                playerRandom = players[random.Next(0, players.Count)];
                groupRandom = groups[random.Next(0, groups.Count)];

                if (counter <= 9)
                {
                    firstRandomTeam = firstTeam[random.Next(0, firstTeam.Count)];
                    secondRandomTeam = secondTeam[random.Next(0, secondTeam.Count)];                    

                    if (counter == 1)
                        firstRandomTeamA = firstRandomTeam;
                    if (counter == 4)
                        secondRandomTeamA = secondRandomTeam;
                    if (counter == 5)
                        firstRandomTeamB = firstRandomTeam;
                    if (counter == 6)
                        secondRandomTeamB = secondRandomTeam;
                    if (counter == 9)
                        firstRandomTeamC = firstRandomTeam;
                    if (counter == 8)
                        secondRandomTeamC = secondRandomTeam;
                }

                if (counter == 10)
                {
                    firstRandomTeam = firstRandomTeamA; 
                    secondRandomTeam = secondRandomTeamA;
                }                    

                if (counter == 11)
                {
                    firstRandomTeam = firstRandomTeamB; 
                    secondRandomTeam = secondRandomTeamB;
                }                    

                if (counter == 12)
                {
                    firstRandomTeam = firstRandomTeamC; 
                    secondRandomTeam = secondRandomTeamC;
                }                    

                PlayerTeam playerTeam = new PlayerTeam
                {
                    Player = playerRandom,
                    FirstTeam = firstRandomTeam,
                    SecondTeam = secondRandomTeam,
                    GroupPosition = groupRandom
                };

                Print(playerTeam);

                PlayerTeamFinal.Add($"{groupRandom} | {secondRandomTeam} | {firstRandomTeam} | {playerRandom}");

                SaveToFile(groupRandom,secondRandomTeam,firstRandomTeam,playerRandom);

                firstTeam.Remove(firstRandomTeam);
                secondTeam.Remove(secondRandomTeam);
                players.Remove(playerRandom);
                groups.Remove(groupRandom);

                counter++;
            }
            return null;
        }

        public void Print(PlayerTeam playerTeam)
        {
            Console.WriteLine(@$"   Posição no grupo: {playerTeam.GroupPosition}");
            Spin();
            Console.WriteLine(@$"   Time do Pote B: {playerTeam.SecondTeam}");
            Spin();
            Console.WriteLine(@$"   Time do Pote A: {playerTeam.FirstTeam}");
            Spin();
            Console.WriteLine(@$"   Jogador: {playerTeam.Player}");
            Spin();
            Console.WriteLine("");
            Console.WriteLine("=============================================================");
        }

        public void Spin()
        {
            int counter = 0;

            ConsoleSpiner spin = new ConsoleSpiner();
            while (counter <= 1)
            {
                Thread.Sleep(100);
                spin.Turn();
                counter++;
            }
        }

        public void SaveToFile(string groupRandom, string secondRandomTeam, string firstRandomTeam, string playerRandom)
        {
            string fileName = $"1 FIFA Santa Copa - {Program.dateTimeKey}.txt";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            using TextWriter tw = new StreamWriter(path, true);
            tw.WriteLine("");
            tw.WriteLine(@$"Posição no grupo: {groupRandom}");
            tw.WriteLine(@$"Time do Pote B: {secondRandomTeam}");
            tw.WriteLine(@$"Time do Pote A: {firstRandomTeam}");
            tw.WriteLine(@$"Jogador: {playerRandom}");
            tw.WriteLine("===============================================");
        }

    }
}
