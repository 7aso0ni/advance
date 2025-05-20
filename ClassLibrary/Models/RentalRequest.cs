using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("Rental_Request")]
public partial class RentalRequest
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Equipment_ID")]
    public int EquipmentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReturnDate { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal Cost { get; set; }

    public int RentalStatus { get; set; }

    public int UserId { get; set; }
    public int? RentalTransactionId { get; set; }

    [ForeignKey("RentalTransactionId")]
    public virtual RentalTransaction? Transaction { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("RentalRequests")]
    public virtual User User { get; set; } = null!;

    [ForeignKey("EquipmentId")]
    [InverseProperty("RentalRequests")]
    public virtual Equipment Equipment { get; set; } = null!;

    [ForeignKey("RentalStatus")]
    [InverseProperty("RentalRequests")]
    public virtual RentalStatus RentalStatus1 { get; set; } = null!;

    [ForeignKey("RentalStatus")]
    [InverseProperty("RentalRequests")]
    public virtual ProductStatus RentalStatusNavigation { get; set; } = null!;
}
