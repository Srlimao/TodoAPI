using System;

namespace TodoAPI
{
    public class TodoItem
    {
        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsChecked { get; set; }

    }
}
