namespace Iterator
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }

        public Song(string title, string artist, string album)
        {
            Title = title;
            Artist = artist;
            Album = album;
        }

        public override string ToString()
        {
            return $"{Title} by {Artist} from the album {Album}";
        }
    }

}
