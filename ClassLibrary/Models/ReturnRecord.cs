using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("Return_Record")]
public partial class ReturnRecord
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int Equipment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReturnDate { get; set; }

    public int Condition { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? LateFees { get; set; }

    [ForeignKey("Condition")]
    [InverseProperty("ReturnRecords")]
    public virtual ConditionStatus ConditionNavigation { get; set; } = null!;

    [ForeignKey("Equipment")]
    [InverseProperty("ReturnRecords")]
    public virtual Equipment EquipmentNavigation { get; set; } = null!;
}
