using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

public partial class Equipment
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(300)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column("CategoryID")]
    public int CategoryId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal Price { get; set; }

    [Column("Available_ID")]
    public int AvailableId { get; set; }

    [Column("Condition_ID")]
    public int ConditionId { get; set; }

    [ForeignKey("AvailableId")]
    [InverseProperty("Equipment")]
    public virtual AvailableStatus Available { get; set; } = null!;

    [ForeignKey("CategoryId")]
    [InverseProperty("Equipment")]
    public virtual Category Category { get; set; } = null!;

    [ForeignKey("ConditionId")]
    [InverseProperty("Equipment")]
    public virtual ConditionStatus Condition { get; set; } = null!;

    [InverseProperty("EquipmentNavigation")]
    public virtual ICollection<FeedBack> FeedBacks { get; set; } = new List<FeedBack>();

    [InverseProperty("Equipment")]
    public virtual ICollection<RentalRequest> RentalRequests { get; set; } = new List<RentalRequest>();

    [InverseProperty("EquipmentNavigation")]
    public virtual ICollection<ReturnRecord> ReturnRecords { get; set; } = new List<ReturnRecord>();

    public byte[] Image { get; set; } = null!;

}
