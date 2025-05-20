using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("FeedBack")]
public partial class FeedBack
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Notes { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    public TimeOnly Time { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Comment { get; set; } = null!;

    public int Equipment { get; set; }

    [ForeignKey("Equipment")]
    [InverseProperty("FeedBacks")]
    public virtual Equipment EquipmentNavigation { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("FeedBacks")]
    public virtual User User { get; set; } = null!;
}
