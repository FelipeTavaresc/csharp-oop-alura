namespace ScreenSound
{
    class Music
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public int DurationTime { get; set; }
        public bool Available { get; set; }
        public string FullName { get; set; }


        public void ShowMusicInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Duration time: {DurationTime}");
            if (Available)
                Console.WriteLine("Available");
            else
                Console.WriteLine("Not Available in your plan");
        }
    }
}
