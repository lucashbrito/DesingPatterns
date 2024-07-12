using System.Collections.Generic;

namespace Iterator
{
    public class Playlist : IAggregate<Song>
    {
        private readonly List<Song> _songs = new List<Song>();

        public IIterator<Song> CreateIterator()
        {
            return new PlaylistIterator(_songs);
        }

        public void AddSong(Song song)
        {
            _songs.Add(song);
        }
    }

}
