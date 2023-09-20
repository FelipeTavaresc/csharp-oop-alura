using ScreenSound;

Band band = new Band();
band.Name = "Queen";

Album queenAlbum = new Album();
queenAlbum.Name = "A night at the opera";

Music music1 = new Music(band);
music1.Name = "Love of my life";
music1.DurationTime = 213;

Music music2 = new Music(band);
music2.Name = "Bohemian Rhapsody";
music2.DurationTime = 354;

queenAlbum.AddMusic(music1);
queenAlbum.AddMusic(music2);
queenAlbum.ShowMusicAlbum();

band.AddAlbum(queenAlbum);
band.ShowDiscography();
