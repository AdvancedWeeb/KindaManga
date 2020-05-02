using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace MangaDesktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MangaNotFoundedEvent()
        {
            MessageBox.Show("Unfortunately, there's no such mangas", "Error");
            MangasControl.ItemsSource = null;
        }

        private void MangaFoundedEvent(List<MangaView> entry)
        {
            MangasControl.ItemsSource = null;
            MangasControl.ItemsSource = entry;
        }

        private void readButtonClickEventHandler(object sender, RoutedEventArgs e) => Process.Start((sender as Button).Tag.ToString());

        private void searchButtonClickEventHandler(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text != string.Empty)
            {
                string mangaName = SearchBox.Text;

                FillWhileLoading();

                MangaParsing.MangaParsing parsingInstance = new MangaParsing.MangaParsing();

                parsingInstance.GetMangas(mangaName);

                parsingInstance.OnMangaHasBeenFoundedEventHandler += MangaFoundedEvent;
                parsingInstance.OnMangasHasNotBeenFoundedEventHandler += MangaNotFoundedEvent;
            }

            else MessageBox.Show("You should fill the search field!", "Error");
        }

        private void FillWhileLoading()
        {
            MangasControl.ItemsSource = new object[] {
                new Label() { Content = "Please, wait while loading..." }
            };
        }
    }
}
