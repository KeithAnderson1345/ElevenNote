using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models //VIEW MODELS REPRESENT THE DATA THAT WE WANT TO SHOW ON THE PAGE. THEY ARE USEFUL BECAUSE YOU CAN PULL SPECIFIC PROPERITES FROM MULTIPLE TABLES 
{                           //THIS LAYER WILL BE USED TO HOUSE THE MODELS FOR THE APPLICATION. THESE MODELS WILL BE CLASSES USED IN ALMOST ALL LAYERS OF THE APP.
    public class NoteDetail  //This model class will let us view all the properties of the note. 
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
