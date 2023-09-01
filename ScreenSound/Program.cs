using ScreenSound;

Music music1 = new Music();
music1.name = "Roxane";
music1.artist = "The Police";
music1.durationTime = 270;
music1.available = true;

Music music2 = new Music();
music2.name = "Vertigo";
music2.artist = "U2";
music2.durationTime = 350;
music2.available = false;

music1.ShowMusicInfo();
music2.ShowMusicInfo();