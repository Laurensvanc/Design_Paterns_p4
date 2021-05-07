using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class MP3Player : IObservable
    {
        public Song currentSong { get; private set; }
        public List<Song> songList = new List<Song>() {
            new Song("Bruno Mars", "Billionaire", "03:31"),
            new Song("Pink Floyd", "Wish You Were Here", "03:12"),
            new Song("Editors", "Papillon", "05:24"),
            new Song("Led Zeppelin", "Dazed and Confused", "6:26")
        };
        public List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NextSong()
        {
            Random rnd = new Random();
            currentSong = songList[rnd.Next(0, songList.Count)];

            NotifyObservers();
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(currentSong);
            }
        }
    }
}
