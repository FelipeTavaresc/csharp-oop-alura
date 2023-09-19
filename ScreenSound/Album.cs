namespace ScreenSound
{
    public class Album
    {
        private List<Music> music = new List<Music>();
        public string Name { get; set; }
        public int Duration { get; set; }


        public void AddMusic(Music music)
        {
            this.music.Add(music);
        }
    }
}
