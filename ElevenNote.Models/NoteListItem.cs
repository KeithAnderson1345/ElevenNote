using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models //VIEW MODELS REPRESENT THE DATA THAT WE WANT TO SHOW ON THE PAGE. THEY ARE USEFUL BECAUSE YOU CAN PULL SPECIFIC PROPERITES FROM MULTIPLE TABLES 
{                           //THIS LAYER WILL BE USED TO HOUSE THE MODELS FOR THE APPLICATION. THESE MODELS WILL BE CLASSES USED IN ALMOST ALL LAYERS OF THE APP.
    public class NoteListItem //This class model will handle the task of collectiong property data for a list of notes. When a user enters info, we want them to enter
        //specific data. When we show info, we will want to show specific data in specific views. 
    {
        public int NoteId { get; set; }
        public string Title { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
