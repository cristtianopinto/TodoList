using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TodoList.Models
{
    public class Tache
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Nom { get; set; }

        [StringLength(250)] // atribut de validation
        public string Description { get; set; }


        public DateTime? DateFin { get; set; }//nullable

        [Required]
        public bool Statut { get; set; }

        public int? Priorite { get; set; }

        // clé étrangère
        public int CategorieID { get; set; }

        [ForeignKey("CategorieID")] 
        public Categorie Categorie { get; set; }
        // FIN: clé étrangère

    }
}