using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Assignment2Data.Animal
{
    public class Animals
    {
        [Key]
        public int AniId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Animal name Required")]
        public string AniName { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Animal type Required")]
        public string AniType { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Animal breed Required")]
        public string AniBreed { get; set; }

        
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Animal Date of Birth Required")]
        public DateTime AniDoB { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Animal Description Required")]
        public string AniDesc { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Animal Picture Required")]
        public string AniPic { get; set; }
    }
}
