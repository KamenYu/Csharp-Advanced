using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Task4
{
    class Program
    {
        private const string TimeFormat = @"hh\:mm\:ss";

        static void Main(string[] args)
        {
            string favouriteGenre = Console.ReadLine();
            string durationPref = Console.ReadLine(); // Long || Short

            List<Movie> movies = new List<Movie>();

            string possibleMovie;

            while ((possibleMovie = Console.ReadLine()) != "POPCORN!")
            {
                string[] tokens = possibleMovie.Split('|');
                TimeSpan movieSpan = TimeSpan.ParseExact(tokens[2], TimeFormat, CultureInfo.InvariantCulture);
                Movie movie = new Movie(tokens[0],tokens[1], movieSpan);
                movies.Add(movie);
            }

            bool isShort = durationPref == "Short";

            List<Movie> selected = movies
                .Where(m => m.Genre == favouriteGenre)
                .OrderBy(d => isShort ? d.Duration : -d.Duration)
                .ThenBy(x => x.Name)
                .ToList();

            string answer = null;
            int index = -1;

            while (answer != "Yes")
            {
                index++;
                Console.WriteLine(selected[index]);
                
                answer = Console.ReadLine();
            }

            string chosenMovieDuration = selected[index].Duration.ToString(TimeFormat, CultureInfo.InvariantCulture);
            Console.WriteLine($"We're watching {selected[index].Name} - {chosenMovieDuration}");

            long totalPlaylistTicks = movies.Sum(s => s.Duration.Ticks);
            TimeSpan timeSpan = new TimeSpan(totalPlaylistTicks);
            string totalPlaylistDuration = timeSpan.ToString(TimeFormat, CultureInfo.InstalledUICulture);

            Console.WriteLine($"Total Playlist Duration: {totalPlaylistDuration}");
        }

        public class Movie
        {
            public Movie(string name, string genre, TimeSpan duration)
            {
                Name = name;
                Genre = genre;
                Duration = duration;
            }

            public string Name { get; set; }
            public string Genre { get; set; }
            public TimeSpan Duration { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}
