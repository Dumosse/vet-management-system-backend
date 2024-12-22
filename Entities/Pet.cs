using System.ComponentModel.DataAnnotations;

namespace backend.Entities{

    public class Pet{
        [Key]
        public int PetId {get; set;} 
        public string Name {get; set;}
        public string Breed {get; set;}
        public int Age {get; set;}
        public string MedicalHistory {get; set;}

        //Foreign Key
        public int OwnerId {get; set;}
        public User Owner {get; set;} // many-to-one relationship with user (pet owner)

        //Navigation Property
        public ICollection<Appointment> Appointments {get; set;} // one-to-many relationship with Appointments

    }
}