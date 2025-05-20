using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("Log")]
public partial class Log
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Action { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TimeStamp { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string AffectedData { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Source { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Logs")]
    public virtual User User { get; set; } = null!;
}
