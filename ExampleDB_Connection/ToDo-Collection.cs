using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Automation;
using Vorlage_Klausur;

namespace ExampleDB_Connection
{
    internal class ToDo_Collection
    {
        internal List<ToDo> to_do_list = new List<ToDo>(); // creates new List to store Tasks

        internal DB_Connection db_connection = new DB_Connection(); // creates new Sql Connection

        public List<ToDo> GetAllTodos()
        {
            List<ToDo> output = new List<ToDo>();
            DataTable dataTable = db_connection.ReadData("SELECT * FROM todo"); // returns complete sql table "todo"

            foreach (DataRow row in dataTable.Rows)
            {
                string status = null;
                switch (row["status"])
                {
                    case 0: status = "Incomplete";
                        break;
                    case 1: status = "In Progress";
                        break;
                    case 2: status = "Complete";
                        break;
                }
                ToDo temp = new ToDo() // creates new "ToDo" object
                {
                    // converts each row of information from the DataTable and sets the attributes of the object to them
                    ID = Convert.ToInt32(row["id"]),
                    Content = Convert.ToString(row["content"]),
                    Status = status
                };
                output.Add(temp); // adds the new object to the output list
            }
            return output;
        }

        public void CreateToDo(string content, string status)
        {
            db_connection.WriteData($"INSERT INTO todo(content,status) VALUES('" + content + "'," + status +")");
        }

        public void DeleteToDo(int id) {
            db_connection.WriteData("DELETE FROM todo WHERE id = " + Convert.ToString(id));
            MessageBox.Show("Successfully removed Task with id " + id);
        }
    }
}
