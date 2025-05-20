using System;
using System.Collections.Generic;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Graph.Models;
using User = ClassLibrary.Models.User;
using System.IO;


namespace ClassLibrary.Persistence;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AvailableStatus> AvailableStatuses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<ConditionStatus> ConditionStatuses { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<FeedBack> FeedBacks { get; set; }

    public virtual DbSet<FeedBack1> FeedBacks1 { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationType> NotificationTypes { get; set; }

    public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }

    public virtual DbSet<ProductStatus> ProductStatuses { get; set; }

    public virtual DbSet<RentalRequest> RentalRequests { get; set; }

    public virtual DbSet<RentalStatus> RentalStatuses { get; set; }

    public virtual DbSet<RentalTransaction> RentalTransactions { get; set; }

    public virtual DbSet<ReturnRecord> ReturnRecords { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=NewDB;Trusted_Connection=True;");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var imagePath = Path.Combine(AppContext.BaseDirectory, "SeedImages", "camera.jfif");
        byte[] imageBytes = File.Exists(imagePath) ? File.ReadAllBytes(imagePath) : null;

        if (imageBytes != null)
        {
            //modelBuilder.Entity<Equipment>().HasData(
            //    new Equipment
            //    {
            //        Id = 100, 
            //        Name = "Canon EOS R8",
            //        Description = "High-quality mirrorless camera with RF 24–50mm lens.",
            //        CategoryId = 2,         // Assuming "Cameras" category has ID 2
            //        Price = 150,            // Price per day
            //        AvailableId = 1,        // Available
            //        ConditionId = 1,        // New
            //        Image = imageBytes
            //    }
            //);
        }


        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserRole>().HasData(
            new UserRole { Id = 1, Role = "Admin" },
            new UserRole { Id = 2, Role = "Manager" },
            new UserRole { Id = 3, Role = "Customer" }
        );
        modelBuilder.Entity<ConditionStatus>().HasData(
             new ConditionStatus { Id = 1, Status = "New" },
             new ConditionStatus { Id = 2, Status = "Good" },
            new ConditionStatus { Id = 3, Status = "Damaged" },
             new ConditionStatus { Id = 4, Status = "Refurbished" }
        );
        modelBuilder.Entity<AvailableStatus>().HasData(
            new AvailableStatus { Id = 1, Status = "Available" },
            new AvailableStatus { Id = 2, Status = "Unavailable" },
            new AvailableStatus { Id = 3, Status = "Under Maintenance" }
        );
        modelBuilder.Entity<Category>().HasData(
         new Category { Id = 1, Name = "Power Tools" },
         new Category { Id = 2, Name = "Cameras" },
         new Category { Id = 3, Name = "Construction" },
         new Category { Id = 4, Name = "Event Supplies" }
        );
        modelBuilder.Entity<RentalStatus>().HasData(
            new RentalStatus { Id=1,Status="Pending"},
            new RentalStatus { Id=2,Status= "Approved" },
            new RentalStatus { Id=3,Status= "Rejected" },
            new RentalStatus { Id=4,Status= "Cancelled" },
            new RentalStatus { Id=5,Status= "Active" },
            new RentalStatus { Id=6,Status= "Returned" },
            new RentalStatus { Id=7,Status= "Overdue" },
            new RentalStatus { Id=8,Status= "Completed" }
            );
        modelBuilder.Entity<ProductStatus>().HasData(
    new ProductStatus { Id = 1, AvailableId = 1, ConditionId = 1 },
    new ProductStatus { Id = 2, AvailableId = 1, ConditionId = 1 },
    new ProductStatus { Id = 3, AvailableId = 1, ConditionId = 1 },
    new ProductStatus { Id = 4, AvailableId = 1, ConditionId = 1 },
    new ProductStatus { Id = 5, AvailableId = 1, ConditionId = 1 },
    new ProductStatus { Id = 6, AvailableId = 1, ConditionId = 1 },
    new ProductStatus { Id = 7, AvailableId = 1, ConditionId = 1 },
    new ProductStatus { Id = 8, AvailableId = 1, ConditionId = 1 }

);
        modelBuilder.Entity<DocumentType>().HasData(
new DocumentType { Id = 1, Name = "Rental Agreement" },
new DocumentType { Id = 2, Name = "Payment Receipt" },
new DocumentType { Id = 3, Name = "Return Report" },
new DocumentType { Id = 4, Name = "ID Proof" }
);



        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasOne(d => d.DocumentTypeNavigation).WithMany(p => p.Documents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_Document_Type");

            entity.HasOne(d => d.User).WithMany(p => p.Documents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_User");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasOne(d => d.Available).WithMany(p => p.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipment_Available_Status");

            entity.HasOne(d => d.Category).WithMany(p => p.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipment_Category");

            entity.HasOne(d => d.Condition).WithMany(p => p.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Equipment_Condition_Status");
        });

        modelBuilder.Entity<FeedBack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Table2");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.FeedBacks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FeedBack_Equipment");

            entity.HasOne(d => d.User).WithMany(p => p.FeedBacks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FeedBack_User");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasOne(d => d.User).WithMany(p => p.Logs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Log_User");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasOne(d => d.NotificationType).WithMany(p => p.Notifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notification_Notification_Type");

            entity.HasOne(d => d.User).WithMany(p => p.Notifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notification_User");
        });
        modelBuilder.Entity<NotificationType>().HasData(
    new NotificationType { Id = 1, Type = "Unread" },
    new NotificationType { Id = 2, Type = "Read" }
);
    

        modelBuilder.Entity<RentalRequest>(entity =>
        {
            entity.HasOne(d => d.Equipment).WithMany(p => p.RentalRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Request_Equipment");

            entity.HasOne(d => d.RentalStatusNavigation).WithMany(p => p.RentalRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Request_Product_Status");

            entity.HasOne(d => d.RentalStatus1).WithMany(p => p.RentalRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Request_Rental_Status");

            entity.HasOne(d => d.Transaction)
        .WithMany()
        .HasForeignKey(d => d.RentalTransactionId)
        .OnDelete(DeleteBehavior.SetNull)
        .HasConstraintName("FK_Rental_Request_Rental_Transaction");
        });

        modelBuilder.Entity<RentalTransaction>(entity =>
        {
            entity.HasOne(d => d.PaymentStatusNavigation).WithMany(p => p.RentalTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Transaction_Payment_Status");

            entity.HasOne(d => d.RentalStatusNavigation).WithMany(p => p.RentalTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Transaction_Rental_Status");

            entity.HasOne(d => d.User).WithMany(p => p.RentalTransactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Transaction_User");

        });

        modelBuilder.Entity<ReturnRecord>(entity =>
        {
            entity.HasOne(d => d.ConditionNavigation).WithMany(p => p.ReturnRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Return_Record_Condition_Status");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.ReturnRecords)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Return_Record_Equipment");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }
    public void SeedImageEquipment()
    {
        if (!Equipment.Any(e => e.Name == "Canon EOS R8"))
        {
            var imagePath1 = Path.Combine(AppContext.BaseDirectory, "SeedImages", "camera.jfif");
            byte[] imageBytes1 = File.Exists(imagePath1) ? File.ReadAllBytes(imagePath1) : new byte[0];

            Equipment.Add(new Equipment
            {
                Name = "Canon EOS R8",
                Description = "High-quality mirrorless camera with RF 24–50mm lens.",
                CategoryId = 2,
                Price = 150,
                AvailableId = 1,
                ConditionId = 1,
                Image = imageBytes1
            });
        }

        if (!Equipment.Any(e => e.Name == "Leitz Elmar Vintage"))
        {
            var imagePath2 = Path.Combine(AppContext.BaseDirectory, "SeedImages", "camera1.jpg");
            byte[] imageBytes2 = File.Exists(imagePath2) ? File.ReadAllBytes(imagePath2) : new byte[0];

            Equipment.Add(new Equipment
            {
                Name = "Leitz Elmar Vintage",
                Description = "Classic vintage camera with a 5cm f/3.5 lens.",
                CategoryId = 2,
                Price = 100,
                AvailableId = 1,
                ConditionId = 2,
                Image = imageBytes2
            });
        }

        if (!Equipment.Any(e => e.Name == "Mirrorless Z Alpha"))
        {
            var imagePath3 = Path.Combine(AppContext.BaseDirectory, "SeedImages", "camera2.avif");
            byte[] imageBytes3 = File.Exists(imagePath3) ? File.ReadAllBytes(imagePath3) : new byte[0];

            Equipment.Add(new Equipment
            {
                Name = "Mirrorless Z Alpha",
                Description = "Advanced mirrorless camera with large sensor and fast autofocus.",
                CategoryId = 2,
                Price = 180,
                AvailableId = 1,
                ConditionId = 1,
                Image = imageBytes3
            });
        }

        SaveChanges();
    }


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
