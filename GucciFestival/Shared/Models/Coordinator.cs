using System;
using System.ComponentModel.DataAnnotations;

namespace GucciFestival.Shared.Models
{

        public class Coordiantor
        {
            //Her er de properties vi gerne vil læse fra vores shelterdatabase
            [Required]
            public string Cvr_navn { get; set; }

            

            //en tom constructor. Dem er vi glade for :)
            
        }
    }


