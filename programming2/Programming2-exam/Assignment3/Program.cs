using System.Runtime.CompilerServices;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            List<Song> songs = ReadSongs("top2000-2022.csv");
            Console.WriteLine($"number of songs: {songs.Count}");
            Console.WriteLine();
            DisplaySongs(songs, 95, 100);
            Console.WriteLine();
            DisplayYearSongs(GetYearSongs(songs), 50);
        }
        List<Song> ReadSongs(string filename)
        {
            List<Song> songs = new List<Song>();
            StreamReader reader = new StreamReader(filename);
            if (filename.Length == 0)
                return songs;
            while(!reader.EndOfStream)
            {
                Song song = new Song();
                string line = reader.ReadLine();
                string[] info = line.Split(';');
                song.Ranking = int.Parse(info[0]);
                song.Title = info[1];
                song.Artist = info[2];
                song.Year = int.Parse(info[3]);
                songs.Add(song);  
            }
            reader.Close();
            return songs;
        }
        void DisplaySongs(List<Song> songs, int startRanking, int endRanking)
        {
            foreach(Song song in songs)
            {
                if(song.Ranking >= startRanking && song.Ranking <= endRanking)
                {
                    Console.WriteLine($"{song.Ranking}. {song.Artist} - {song.Title}");
                }
            }
        }
        Dictionary<int, List<Song>> GetYearSongs(List<Song> songs)
        {
            Dictionary<int, List<Song>> yearSongs = new Dictionary<int, List<Song>>();

            foreach( Song song in songs)
            {
                if (!yearSongs.ContainsKey(song.Year))
                {
                    yearSongs.Add(song.Year, new List<Song>());
                }
                yearSongs[song.Year].Add(song);
            }
            return yearSongs;
        }
        void DisplayYearSongs(Dictionary<int, List<Song>> yearSongs, int minimum)
        {
            Console.WriteLine($"year songs (with at least {minimum} songs): ");
            foreach(int year in yearSongs.Keys)
            {
                int count = yearSongs[year].Count;
                if (count >= minimum)
                    Console.WriteLine($"{year}: {count}");
            }
        }
    }
}