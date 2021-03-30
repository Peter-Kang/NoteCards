using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteCards.Models
{
    public class NoteCard
    {
        /// <summary>
        /// The note card ID, this should be a unique GUID  
        /// </summary>
        public String NoteCardID { get; set; }

        /// <summary>
        /// The details of the  note card
        /// </summary>
        public String Details { get; set; }

        /// <summary>
        /// The date time that the card was created
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// The date time that the object was last modifed
        /// </summary>
        public DateTime LastModifiedDate { get; set; }

    }
}
