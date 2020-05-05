using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using MangaParsing;

namespace MangaDesktop
{
    public partial class MainWindow : Window
    {
        private readonly MangaParsing.MangaParsing _parsingInstance = new MangaParsing.MangaParsing();
        
        public MainWindow()
        {
            InitializeComponent();
            _parsingInstance.OnMangaHasBeenFoundedEventHandler += MangaFoundedEvent;
            _parsingInstance.OnMangasHasNotBeenFoundedEventHandler += MangaNotFoundedEvent;
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

        private void readButtonClickEventHandler(object sender, RoutedEventArgs e) => Process.Start(sender is Button btn ? btn.Tag.ToString() : throw new NullReferenceException("Хускар)"));
        private void searchButtonClickEventHandler(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text != string.Empty)
            {
                var mangaName = SearchBox.Text;

                FillWhileLoading();

                _parsingInstance.GetMangas(mangaName);
                
            } else MessageBox.Show("You should fill the search field!", "Error");
        }

        private void FillWhileLoading()
        {
            MangasControl.ItemsSource = new object[]
            {
                new Label { Content = "Please, wait while loading..." }
            };
        }
    }
}
