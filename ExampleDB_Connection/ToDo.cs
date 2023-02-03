using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ExampleDB_Connection
{
    internal class ToDo
    {
        public ToDo() { }

        public int ID { get; set; }

        public string Content { get; set; }

        public string Status { get; set; }
    }
}
