using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace backend.Entities{
    public class Invoice{
        [Key]
        public int InvoiceId {get; set;}
        [Precision(18, 2)]
        public decimal TotalAmount {get; set;}
        public PaymentStatus PaymentStatus {get; set;}
        public DateTime IssuedDate {get; set;}

        //Foreign Key
        public int AppointmentId {get; set;}
        public Appointment Appointment{get; set;} //one-to-one relationship with Appointment
    }

    public enum PaymentStatus{
        Paid,
        Unpaid
    }
}