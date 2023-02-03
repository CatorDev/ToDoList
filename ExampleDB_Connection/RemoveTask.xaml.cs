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


    }
}
