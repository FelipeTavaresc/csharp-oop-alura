namespace ScreenSound
{
    public class Music
    {
        public string Name { get; set; }
        public Band Artist { get; }
        public int DurationTime { get; set; }
        public bool Available { get; set; }
        public string Description => $"A música {Name} pertence à banda {Artist.Name}";
        public Genre Genre { get; set; }

        public Music(Band artist)
        {
            Artist = artist;
        }

        public void ShowMusicInfo()
        {
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Artist: {Artist.Name}");
            Console.WriteLine($"Duration time: {DurationTime}");
            if (Available)
                Console.WriteLine("Available");
            else
                Console.WriteLine("Not Available in your plan");
        }
    }
}
