using ElevenNote.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models  //VIEW MODELS REPRESENT THE DATA THAT WE WANT TO SHOW ON THE PAGE. THEY ARE USEFUL BECAUSE YOU CAN PULL SPECIFIC PROPERITES FROM MULTIPLE TABLES. 
{                            //THIS LAYER WILL BE USED TO HOUSE THE MODELS FOR THE APPLICATION. THESE MODELS WILL BE CLASSES USED IN ALMOST ALL LAYERS OF THE APP.
    public class NoteCreate //This class model will allow for some validation for the note properties. 
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public string Content { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
