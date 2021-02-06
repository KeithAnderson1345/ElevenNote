using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data //THIS LAYER WILL BE USED TO HOUSE THE INFO ABOUT THE DATA ENTITIES. THESE ENTITIES WILL MATCH THE DATA TABLES IN TH PROJECT. 
{
    public class Note //Entity model to be used as columns in the SQL table. 
    {
        [Key]
        public int NoteId { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }        

        [Required]
        public Guid OwnerId { get; set; } //Guid is a type that allows a unique, near impossible to replicate, ID for the users or items for the users.

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
