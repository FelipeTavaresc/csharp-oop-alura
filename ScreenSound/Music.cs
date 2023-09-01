using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    class Music
    {
        public string name;
        public string artist;
        public int durationTime;
        public bool available;

        public void ShowMusicInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Artist: {artist}");
            Console.WriteLine($"Duration time: {durationTime}");
            if ( available )
                Console.WriteLine("Available");
            else
                Console.WriteLine("Not Available in your plan");

        }
    }
}
