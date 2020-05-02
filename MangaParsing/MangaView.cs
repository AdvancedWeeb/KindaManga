namespace MangaDesktop
{
    public class MangaView
    {
        public MangaView(string image, string name, string readingUrl, string score, int chapters, int volumes)
        {
            Image = image;
            Name = name;
            ReadingUrl = readingUrl;
            Score = score;
            Chapters = chapters;
            Volumes = volumes;
        }

        public string Image { get; set; }

        public string Name { get; set; }

        public string ReadingUrl { get; set; }

        public string Score { get; set; }

        public int Chapters { get; set; }

        public int Volumes { get; set; }
    }
}
