using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAPI
{
    public static class TodosManager
    {
        static List<TodoItem> todos = new List<TodoItem>();

        public static void AddItem(string title)
        {
            TodoItem todo = new TodoItem();
            todo.Title = title;
            todo.IsChecked = false;
            todo.DueDate = DateTime.Now;//todo

        }

        public static void RemoveItem(string title)
        {

        }

        public static void SetCheckItem(bool check)
        {

        }

        public static List<TodoItem> ListItems()
        {
            return todos;
        }
    }
}
