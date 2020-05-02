using JikanDotNet;
using MangaDesktop;
using System.Collections.Generic;

namespace MangaParsing
{
    public class MangaParsing
    {
        public delegate void OnMangaHasBeenFounded(List<MangaView> entry);

        public event OnMangaHasBeenFounded OnMangaHasBeenFoundedEventHandler;

        public delegate void OnMangasHasNotBeenFounded();

        public event OnMangasHasNotBeenFounded OnMangasHasNotBeenFoundedEventHandler;

        public async void GetMangas(string name)
        {
            IJikan jikan = new Jikan();
            MangaSearchResult searching = await jikan.SearchManga(name);

            if (searching?.Results.Count > 0)
                OnMangaHasBeenFoundedEventHandler?.Invoke(castIntoMangaView(searching.Results));
            else
                OnMangasHasNotBeenFoundedEventHandler?.Invoke();
        }

        private List<MangaView> castIntoMangaView(ICollection<MangaSearchEntry> entry)
        {
            List<MangaView> result = new List<MangaView>();

            foreach (MangaSearchEntry anEntry in entry)
                result.Add(new MangaView(anEntry.ImageURL, anEntry.Title, anEntry.URL, " " + anEntry.Score.ToString(), anEntry.Chapters, anEntry.Volumes.Value));

            return result;
        }
    }
}
