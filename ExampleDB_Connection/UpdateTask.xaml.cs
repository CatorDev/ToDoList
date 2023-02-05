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

            HeadText.Text = "Update Task: " + localTask.Content;

            CurrentContent.Text = localTask.Content;
            CurrentStatus.Text = localTask.Status;
        }

        private void ConfirmUpdate_Click(object sender, RoutedEventArgs e)
        {
            string id = Convert.ToString(localTask.ID);
        }
    }
}
