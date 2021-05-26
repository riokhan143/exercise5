using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercise5v2.Models
{
    public class MushroomModel
    {
        [Key]
        public string ScientificName{get; set;}

        [Required (ErrorMessage ="Please enter scientific name if Common name is not known")]
        public string CommonName{get; set;}

        [Required (ErrorMessage ="Cap Shape required. If none, please write n/a")]
        public string CapShape {get; set;}


        [Required (ErrorMessage ="please input unspecified if biome requries more research")]
        public string Biome{get; set;}


        [Required (ErrorMessage ="Please choose an option")]
        public bool isPsychoactive{get; set;}


        [Required (ErrorMessage ="Please choose poisonous if unspecified. Psychoactive counts as poisonous")]
        public string isPoisonous{get; set;}


        [Required (ErrorMessage ="Please choose either one of the three options")]
        public string Hymenophore{get; set;}

        [Required (ErrorMessage =" Veil Description is Required, if veil is not present please input none")]
        public string Veil{get; set;}


        [Required (ErrorMessage ="Acquire spore print from older Mushrooms")]
        public string SporePrintColor{get; set;}


        [Required (ErrorMessage ="Mushroom color is required. if multiple colors please write the major colors")]
        public string Color{get; set;}

        [Required (ErrorMessage ="Hymenophore color is required.")]
        public string GillColor{get; set;}
    }
}