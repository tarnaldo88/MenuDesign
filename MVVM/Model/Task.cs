
using System;
using System.IO;
using System.Xml.Serialization;

namespace MenuDesign.MVVM.Model
{
    [Serializable]
    internal class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }


        public Task( string name, string desc, int id, DateTime dueDate, bool completed)
        {
            Title = name;
            Description = desc;
            Id = id;
            DueDate = dueDate;
            IsCompleted = completed;
        }

        // Save to XML file
        public void SaveToXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Task));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, this);
            }
        }

        // Load from XML file
        public static Task LoadFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Task));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return (Task)serializer.Deserialize(reader);
            }
        }
    }
}
