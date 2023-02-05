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
            ioc.to_do_collection.to_do_list = ioc.to_do_collection.GetAllTodos();
        }

        private void MarkAsIncomplete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MarkAsInProgress_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MarkAsComplete_Click(object sender, RoutedEventArgs e)
        {

        }


        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            AddTask window = new AddTask(ioc);
            window.Show();

            // executes code, when the temporary window closes
            window.Closing += (s, e) => { ToDoList.ItemsSource = ioc.to_do_collection.GetAllTodos(); ioc.to_do_collection.to_do_list = ioc.to_do_collection.GetAllTodos(); };
        }

        private void UpdateTask_Click(object sender, RoutedEventArgs e)
        {
            // converts the currently selected object in the datagrid to a "ToDo" object
            ToDo selectedTask = ToDoList.SelectedItem as ToDo;

            // checks if the task was casted sucessfully or if none was selected
            if (selectedTask != null)
            {
                UpdateTask window = new UpdateTask(ioc,selectedTask);
                window.Show();
                window.Closing += (s, e) => { ToDoList.ItemsSource = ioc.to_do_collection.GetAllTodos(); ioc.to_do_collection.to_do_list = ioc.to_do_collection.GetAllTodos(); };
            }
            else
            {
                MessageBox.Show("No Task selected!");
            }
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            // converts the currently selected object in the datagrid to a "ToDo" object
            ToDo selectedTask = ToDoList.SelectedItem as ToDo;

            // checks if the task was casted sucessfully or if none was selected
            if (selectedTask != null)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure, you want to Delete the task " + selectedTask.Content, "Yes or No?", MessageBoxButton.YesNo);

                // asks for confirmation, if the user wants to delete the selected task
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        // deletes the entity inside of the database, if the id matches
                        ioc.to_do_collection.db_connection.WriteData("DELETE from todo WHERE id = " + Convert.ToString(selectedTask.ID));

                        // finally refreshes the local list and the datagrid aswell
                        ToDoList.ItemsSource = ioc.to_do_collection.GetAllTodos(); ioc.to_do_collection.to_do_list = ioc.to_do_collection.GetAllTodos();

                        // Confirmation Message
                        MessageBox.Show("Deleted Task " + selectedTask.Content + " with ID " + Convert.ToString(selectedTask.ID) + ".");
                        break;
                    case MessageBoxResult.No:
                        MessageBox.Show("Deletion Canceled!");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("No Task selected!");
            }
        }

        private void DeleteTaskByID_Click(object sender, RoutedEventArgs e)
        {
            // creates a new Window with type RemoveTask
            RemoveTask window = new RemoveTask(ioc);
            window.Show();

            // executes code, when the window closes
            window.Closing += (s, e) => { ToDoList.ItemsSource = ioc.to_do_collection.GetAllTodos(); ioc.to_do_collection.to_do_list = ioc.to_do_collection.GetAllTodos(); };
        }
    }
}
