using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("Rental_Status")]
public partial class RentalStatus
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [InverseProperty("RentalStatus1")]
    public virtual ICollection<RentalRequest> RentalRequests { get; set; } = new List<RentalRequest>();

    [InverseProperty("RentalStatusNavigation")]
    public virtual ICollection<RentalTransaction> RentalTransactions { get; set; } = new List<RentalTransaction>();
}
