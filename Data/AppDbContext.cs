using Microsoft.EntityFrameworkCore;
using backend.Entities;

public class AppDbContext : DbContext{

    public AppDbContext() { }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

    }

    public DbSet<User> Users {get; set;}
    public DbSet<Pet> Pets {get; set;}
    public DbSet<Appointment> Appointments {get; set;}
    public DbSet<Inventory> Inventories {get; set;}
    public DbSet<Invoice> Invoices {get; set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured){
            optionsBuilder.UseSqlServer("Server=localhost;Database=VetClinicDb;Trusted_Connection=True;Encrypt=False;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Invoice>()
            .Property(i => i.TotalAmount)
            .HasPrecision(18, 2);

        modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Veterinarian)
            .WithMany(u => u.Appointments)
            .HasForeignKey(a => a.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Appointment>()
            .HasOne(a => a.Pet)
            .WithMany(p => p.Appointments)
            .HasForeignKey(a => a.PetId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}