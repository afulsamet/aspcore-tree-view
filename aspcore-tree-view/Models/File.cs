namespace TreeView.Models
{
    using System;
    using System.Collections.Generic;

    public class File
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<File> Childs { get; set; } = new List<File>();
    }
}
