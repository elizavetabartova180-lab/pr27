using Kino_Bartova.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Kino_Bartova.Pages.Afisha
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        List<AfishaContext> AllAfishas = AfishaContext.Select();

        public Main()
        {
            InitializeComponent();
            foreach (AfishaContext item in AllAfishas)
            {
                parent.Children.Add(new Items.Item(item, this));
            }
        }
        private void AddRecord(object sender, System.Windows.RoutedEventArgs e) =>
           MainWindow.init.OpenPage(new Pages.Afisha.Add());
    }
}
