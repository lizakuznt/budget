using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace budget
{
    /// <summary>
    /// Логика взаимодействия для newwindow.xaml
    /// </summary>
    public partial class newwindow : Window
    {
        public newwindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (typebox.Text == "" || (Owner as MainWindow).type.Contains(typebox.Text))
                return;
            (Owner as MainWindow).type.Add(typebox.Text);
            (Owner as MainWindow).dropdownmenu.ItemsSource = null;
            (Owner as MainWindow).dropdownmenu.ItemsSource = (Owner as MainWindow).type;
            Close();
        }
    }
}