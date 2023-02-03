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
    /// Interaktionslogik für RemoveTask.xaml
    /// </summary>
    public partial class RemoveTask : Window
    {
        IO_Controller localIOC;
        public RemoveTask(IO_Controller publicIOC)
        {
            InitializeComponent();
            localIOC = publicIOC;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            int id;
            //MessageBox.Show(Convert.ToString(id));

            Int32.TryParse(Input.Text, out id);

            /*
            if(Int32.TryParse(Input.Text, out id))
            {
                MessageBox.Show("Tryparse sucess");
            }
            else
            {
                MessageBox.Show("Tryparse failure");
            }*/

            //MessageBox.Show(Convert.ToString(id));

            bool successfull = false;

            // checks, if the object, with the id exists
            foreach (ToDo ToDo in localIOC.to_do_collection.to_do_list)
            {
                if (ToDo.ID == id)
                {
                    successfull = true;
                }
            }

            if (successfull == true)
            {
                localIOC.to_do_collection.DeleteToDo(id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid ID!");
            }
        }
    }
}
