using System;
using System.Collections.Generic;

namespace TodoAPI
{
    public static class TodosManager
    {
        static List<TodoItem> todos = new List<TodoItem>();

        public static void AddItem(string title,DateTime dueDate = new DateTime())
        {
            TodoItem todo = new TodoItem();
            todo.Title = title;
            todo.IsChecked = false;
            todo.DueDate = dueDate;//todo
            todos.Add(todo);

        }

        public static void RemoveItem(string title)
        {
            todos.RemoveAll(x => x.Title == title);
        }

        public static void SetCheckItem(string title,bool check)
        {
            TodoItem todo = todos.Find(x => x.Title == title);
            if (todo == null) return;
            todo.IsChecked = check;
        }

        public static List<TodoItem> ListItems()
        {
            return todos;
        }
    }
}
