namespace ScreenSound
{
    public class Album
    {
        private List<Music> musicList = new List<Music>();
        public string Name { get; set; }
        public int Duration => musicList.Sum(m => m.DurationTime);


        public void AddMusic(Music music)
        {
            musicList.Add(music);
        }

        public void ShowMusicAlbum()
        {
            Console.WriteLine($"A list of album music {Name} \n");
            musicList.ForEach(m => Console.WriteLine($"Music: {m.Name}"));
            Console.WriteLine($"To hear all album you need {Duration} seconds");
        }
    }
}
