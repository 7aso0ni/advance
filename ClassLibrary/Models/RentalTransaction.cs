using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("Rental_Transaction")]
public partial class RentalTransaction
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int RentalStatus { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Pickup { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReturnDate { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal Period { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal Fee { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal Deposit { get; set; }

    public int PaymentStatus { get; set; }

    [ForeignKey("PaymentStatus")]
    [InverseProperty("RentalTransactions")]
    public virtual PaymentStatus PaymentStatusNavigation { get; set; } = null!;

    [ForeignKey("RentalStatus")]
    [InverseProperty("RentalTransactions")]
    public virtual RentalStatus RentalStatusNavigation { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("RentalTransactions")]
    public virtual User User { get; set; } = null!;
}
