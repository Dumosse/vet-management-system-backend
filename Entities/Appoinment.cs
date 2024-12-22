using System.ComponentModel.DataAnnotations;


namespace backend.Entities{
    public class Appointment{
        [Key]
        public int AppointmentId {get; set;}
        public DateTime AppointmentDate {get; set;}
        public string Purpose {get; set;}

        //Foreign Keys
        public int PetId {get; set;}
        public Pet Pet {get; set;} // many-to-one relationship with Pet
        public int UserId{get; set;} // Veterinary (user)
        public User Veterinarian{get; set;} // many-to-one relationship with User (vet)

        //Navigation Property
        public Invoice Invoice {get; set;} // one-to-one relationship with Invoice

    }
}