using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExampleDB_Connection
{
    /// <summary>
    /// Interaktionslogik für UpdateTask.xaml
    /// </summary>
    public partial class UpdateTask : Window
    {
        private ToDo localTask;
        private IO_Controller localIOC;
        public UpdateTask(IO_Controller globalIOC,ToDo globalTask)
        {
            InitializeComponent();

            localTask = globalTask;
            localIOC = globalIOC;

            HeadText.Text = "Update Task: " + localTask.Content;

            CurrentContent.Text = localTask.Content;
            CurrentStatus.Text = localTask.Status;
        }

        private void ConfirmUpdate_Click(object sender, RoutedEventArgs e)
        {
            int id = localTask.ID;
            string content = localTask.Content;
            int status = 0;

            if (UpdateContent.IsChecked == true)
            {
                content =  NewContent.Text;
            }

            if(UpdateStatus.IsChecked == true)
            {
                if (Incomplete.IsChecked == true)
                {
                    status = 0;
                }

                if (InProgress.IsChecked == true)
                {
                    status = 1;
                }

                if (Complete.IsChecked == true)
                {
                    status = 2;
                }
            }

            if (UpdateContent.IsChecked == false && UpdateStatus.IsChecked == false) 
            {
                MessageBox.Show("Nothing will change, please enable at least one of the updates!");
            }
            else
            {
                localIOC.to_do_collection.UpdateToDo(id, content, status);
                MessageBox.Show("Updated Task");
                this.Close();
            }
        }
    }
}
