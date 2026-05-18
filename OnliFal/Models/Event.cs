using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace OnliFal.Models;

public class Event
{
    
        [Key] internal long Id { get; set; }

        [Required] [StringLength(100)] internal string Name { get; set; }
        
        [Required] internal string Type {get;set;}
                
        [Required] [StringLength(2000)] internal string Description { get; set; }

        [Required] [StringLength(100)] internal String ImageLink { get; set; }

        [Required] internal DateTime Date { get; set; }

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

    

