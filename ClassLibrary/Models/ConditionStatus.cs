using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("Condition_Status")]
public partial class ConditionStatus
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [InverseProperty("Condition")]
    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    [InverseProperty("ConditionNavigation")]
    public virtual ICollection<ReturnRecord> ReturnRecords { get; set; } = new List<ReturnRecord>();
}
