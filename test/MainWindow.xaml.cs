using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        BindingList<Book> _list = new BindingList<Book>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Book _b1 = new Book()
            {
                Name = "Book 1",
                Author = "Person 1",
                Year = "2017",
                Avatar = @"Image\image1.jpg"
            };

            _list.Add(_b1);

            this.DataContext = _list;
        }
    }
}
