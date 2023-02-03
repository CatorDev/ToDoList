using System;
using System.Collections.Generic;
using System.Data;
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
using Microsoft.VisualBasic; // for Messagebox with Input

namespace ExampleDB_Connection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        internal IO_Controller ioc = new IO_Controller(); // creates IO Controller

        public MainWindow()
        {
            InitializeComponent();
            ToDoList.ItemsSource = ioc.to_do_collection.GetAllTodos();
        }

        private void MarkAsDone_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MarkAsInProgress_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            AddTask temp = new AddTask(ioc);
            temp.Show();
            // executes code, when the temporary window closes
            temp.Closing += (s, e) => { ToDoList.ItemsSource = ioc.to_do_collection.GetAllTodos(); };
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
