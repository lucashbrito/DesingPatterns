using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var playlist = new Playlist();

            playlist.AddSong(new Song("Song 1", "Artist A", "Album X"));
            playlist.AddSong(new Song("Song 2", "Artist B", "Album Y"));
            playlist.AddSong(new Song("Song 3", "Artist C", "Album Z"));

            IIterator<Song> iterator = playlist.CreateIterator();

            Console.WriteLine("Iterating through the playlist:");

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
        }
    }
}
