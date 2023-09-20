using ScreenSound;

class Band
{
    private List<Album> albums = new List<Album>();

    public string Name { get; set; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discography of band {Name}");
        albums.ForEach(x => Console.WriteLine($"Album: {x.Name} ({x.Duration})"));
    }
}