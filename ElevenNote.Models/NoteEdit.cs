using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models //VIEW MODELS REPRESENT THE DATA THAT WE WANT TO SHOW ON THE PAGE. THEY ARE USEFUL BECAUSE YOU CAN PULL SPECIFIC PROPERITES FROM MULTIPLE TABLES 
{                           //THIS LAYER WILL BE USED TO HOUSE THE MODELS FOR THE APPLICATION. THESE MODELS WILL BE CLASSES USED IN ALMOST ALL LAYERS OF THE APP.
    public class NoteEdit //Model that will allow us to update a note.
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
