using ScreenSound;

Music music1 = new Music();
music1.Name = "Roxane";
music1.Artist = "The Police";
music1.DurationTime = 270;
music1.Available = true;

Music music2 = new Music();
music2.Name = "Vertigo";
music2.Artist = "U2";
music2.DurationTime = 350;
music2.Available = false;

music1.ShowMusicInfo();
music2.ShowMusicInfo();