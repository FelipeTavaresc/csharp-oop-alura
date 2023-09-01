namespace ScreenSound
{
    class Music
    {
        public string name;
        public string artist;
        public int durationTime;
        public bool Available { get; set; }


        public void ShowMusicInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Artist: {artist}");
            Console.WriteLine($"Duration time: {durationTime}");
            if (Available)
                Console.WriteLine("Available");
            else
                Console.WriteLine("Not Available in your plan");
        }
    }
}
