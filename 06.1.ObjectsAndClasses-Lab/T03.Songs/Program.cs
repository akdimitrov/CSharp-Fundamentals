using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.Songs
{
    class Song
    {
        public Song(string type, string name, string time)
        {
            this.TypeList = type;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('_');
                string type = input[0];
                string name = input[1];
                string time = input[2];
                Song song = new Song(type, name, time);
                songs.Add(song);
            }

            string typeList = Console.ReadLine();
            if (typeList != "all")
            {
                Console.WriteLine(string.Join(Environment.NewLine, songs.FindAll(x => x.TypeList == typeList).Select(x => x.Name)));
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, songs.Select(x => x.Name)));
            }
        }
    }
}
