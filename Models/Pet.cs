using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType {
        Shepherd,
        Poodle,
        Beagle,
        Bulldog, 
        Terrier, 
        Boxer,
        Labrador,
        Retriever
    }

    public enum PetColorType {
        Black, 
        White, 
        Golden,
        Tricolor, 
        Spotted
    }

    public class Pet {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetBreedType Breed { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PetColorType Color { get; set; }

        [ForeignKey("PetOwner")]
        public int PetOwnerId { get; set; }
        public PetOwner petOwner { get; set; }

        public DateTime? CheckedInAt { get; set; }
    } 
}

