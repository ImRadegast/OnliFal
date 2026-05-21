using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace OnliFal.Components.Models;

public class Event
{
    
        [Key]internal long Id { get; set; }

        public string? Name { get; set; } = string.Empty;
        
        public  string Type {get;set;} = string.Empty;
                
        public  string Description { get; set; } = string.Empty;

        public  String ImageLink { get; set; }  = string.Empty;

        public DateTime Date { get; set; } = DateTime.Now;

        public Event(string name,string type ,string description, string imageLink, DateTime date)
        {
            
            Name = name;
            Type = type;
            Description = description;
            ImageLink = imageLink;
            Date = date;
        }

        public Event()
        {
            
        }
}

    

