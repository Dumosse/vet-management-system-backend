using System.ComponentModel.DataAnnotations;

namespace backend.Entities{
    
    public class User{
        [Key]
        public int UserId {get; set;} 
        public string Username{get; set;}
        public string Password{get; set;}
        public string Email{get; set;}
        public UserRole Role{get; set;}
        public DateTime CreatedAt{get; set;}

        //Navigation Properties
        public ICollection<Pet> Pets {get; set;} // one-to-many relationship with Pets
        public ICollection<Appointment> Appointments {get; set;} //one-to-many relationship with Appointments

    }

    public enum UserRole{
        Admin,
        Vet,
        Receptionist,
        PetOwner
    }
}