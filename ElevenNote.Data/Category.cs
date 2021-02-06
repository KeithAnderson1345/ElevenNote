using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
        public enum CategoryType
        {
            ToDoItem = 1,
            SchoolProject,
            WorkProject,
            Reminder,
            FuturePlan,
            Financial,
            Random
        }
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public CategoryType TypeCategory { get; set; }

    }
}
