using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace OnliFal.Models;

public class Event
{
    
        [Key] public long EventId { get; set; }

        [Required] [StringLength(100)] private string Name { get; set; }
        
        [Required] private string Type {get;set;}
                
        [Required] [StringLength(2000)] private string Description { get; set; }

        [Required] [StringLength(100)] private String ImageLink { get; set; }

        [Required] public DateTime StartDate { get; set; }

        private Event(long eventId, string name,string type ,string description, string imageLink, DateTime startDate)
        {
            EventId = eventId;
            Name = name;
            Type = type;
            Description = description;
            ImageLink = imageLink;
            StartDate = startDate;
        }
}

    

