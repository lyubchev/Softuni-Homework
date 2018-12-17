using System;
using System.Linq;
using System.Collections.Generic;

namespace ex1
{
    class Program
    {
        public class CaseInsensitiveComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, true);
            }
        }

        static void Main(string[] args)
        {
            int totalTime = 0;
            string input = Console.ReadLine();
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandsTotalTime = new Dictionary<string, int>();

            while (input != "start of concert")
            {
                string command = input.Split("; ", StringSplitOptions.RemoveEmptyEntries)[0];
                string bandName = input.Split("; ", StringSplitOptions.RemoveEmptyEntries)[1];
                List<string> members = input.Split("; ", StringSplitOptions.RemoveEmptyEntries)[2].Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

                switch (command)
                {
                    case "Add":
                        if (!bands.ContainsKey(bandName))
                        {
                            //foreach (var member in members.ToList())
                            //{
                            //    if(members.Contains(member))
                            //    {
                            //        members.Remove(member);
                            //    }
                            //}
                            //Console.WriteLine("initial members: " + string.Join(" ", members));
                            bands.Add(bandName, members);
                        } else
                        {
                            foreach (var member in members)
                            {
                                if (!bands[bandName].Contains(member))
                                {
                                    bands[bandName].Add(member);
                                }
                            }
                        }
                        break;
                    case "Play":
                        int bandTime = int.Parse(input.Split("; ", StringSplitOptions.RemoveEmptyEntries)[2]);

                        if (bandsTotalTime.ContainsKey(bandName))
                        {
                            bandsTotalTime[bandName] += bandTime;
                        } else
                        {
                            bandsTotalTime[bandName] = bandTime;
                        }

                        if(!bands.ContainsKey(bandName))
                        {
                            bands.Add(bandName, new List<string>());
                        }

                        totalTime += bandTime;
                        break;
                }
                input = Console.ReadLine();
            }

            string band = Console.ReadLine();

            Console.WriteLine($"Total time: {totalTime}");
            foreach (KeyValuePair<string, int> pair in bandsTotalTime.OrderByDescending(key => key.Value).ThenBy(key => key.Key, new CaseInsensitiveComparer()))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

            Console.WriteLine(band);
            foreach (var member in bands[band])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
