using JikanDotNet;
using System.Collections.Generic;
using System.Linq;

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
                OnMangaHasBeenFoundedEventHandler?.Invoke(CastIntoMangaView(searching.Results));
            else
                OnMangasHasNotBeenFoundedEventHandler?.Invoke();
        }

        private static List<MangaView> CastIntoMangaView(IEnumerable<MangaSearchEntry> entry)
        {
            return (from anEntry in entry where anEntry.Volumes != null select new MangaView(anEntry.ImageURL, anEntry.Title, anEntry.URL, " " + anEntry.Score, anEntry.Chapters, anEntry.Volumes.Value)).ToList();
        }
    }
}
