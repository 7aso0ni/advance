using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("Product_Status")]
public partial class ProductStatus
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Available_ID")]
    public int AvailableId { get; set; }

    [Column("Condition_ID")]
    public int ConditionId { get; set; }

    [InverseProperty("RentalStatusNavigation")]
    public virtual ICollection<RentalRequest> RentalRequests { get; set; } = new List<RentalRequest>();
}
