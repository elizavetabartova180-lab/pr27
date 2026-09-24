using Kino_Bartova.Classes;
using System.Windows.Controls;

namespace Kino_Bartova.Pages.Kinoteatr.Items
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        KinoteatrContext Kinoteatr;
        Main main;
        public Item(KinoteatrContext Kinoteatr, Main main)
        {
            InitializeComponent();

            name.Text = Kinoteatr.Name;
            countZal.Text = Kinoteatr.CountZal.ToString();
            count.Text = Kinoteatr.Count.ToString();
            this.Kinoteatr = Kinoteatr;
            this.main = main;

        }

        private void EditRecord(object sender, System.Windows.RoutedEventArgs e) =>
            MainWindow.init.OpenPage(new Pages.Kinoteatr.Add(this.Kinoteatr));

        private void DeletRecord(object sender, System.Windows.RoutedEventArgs e)
        {
            Kinoteatr.Delete();
            main.parent.Children.Remove(this);
        }
    }
}
