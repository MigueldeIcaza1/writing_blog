using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YourStory.API.Models.Story
{
    public class StoryDetails
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string UserName { get; set; }
        public string TagName { get; set; }
        [Required]
        public string Description { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime CreatedOn { get; set; }
        public string FormatedCreatedOn { get; set; }

    }
}
