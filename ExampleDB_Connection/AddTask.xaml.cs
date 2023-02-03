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
using Vorlage_Klausur;

namespace ExampleDB_Connection
{
    /// <summary>
    /// Interaktionslogik für AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        private IO_Controller localIOC;

        public AddTask(IO_Controller globalIOC)
        {
            InitializeComponent();
            localIOC = globalIOC; 
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            // define state of task
            int status = 0;

            if(InProgress.IsChecked == true) { status = 1; }
            if(Complete.IsChecked == true) { status = 2;}

            if (Content.Text != "")
            {
                localIOC.to_do_collection.CreateToDo(Content.Text, Convert.ToString(status));
                MessageBox.Show("Added new Task!\n");
                this.Close();
            }
            else
            {
                MessageBox.Show("The Task Content is Empty!\n");
            }
        }
    }
}
