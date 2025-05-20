using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("User")]
public partial class User
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Fname { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Lname { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("RoleID")]
    public int RoleId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    [InverseProperty("User")]
    public virtual ICollection<FeedBack> FeedBacks { get; set; } = new List<FeedBack>();

    [InverseProperty("User")]
    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    [InverseProperty("User")]
    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    [InverseProperty("User")]
    public virtual ICollection<RentalTransaction> RentalTransactions { get; set; } = new List<RentalTransaction>();

    [InverseProperty("User")]
    public virtual ICollection<RentalRequest> RentalRequests { get; set; } = new List<RentalRequest>();

    [ForeignKey("RoleId")]
    [InverseProperty("Users")]
    public virtual UserRole Role { get; set; } = null!;
}
