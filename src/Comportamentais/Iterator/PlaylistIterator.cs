using System.Collections.Generic;

namespace Iterator
{
    public class PlaylistIterator : IIterator<Song>
    {
        private readonly List<Song> _playlist;
        private int _currentIndex = -1;

        public PlaylistIterator(List<Song> playlist)
        {
            _playlist = playlist;
        }

        public Song Current => _playlist[_currentIndex];

        public bool MoveNext()
        {
            if (_currentIndex < _playlist.Count - 1)
            {
                _currentIndex++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }

}
