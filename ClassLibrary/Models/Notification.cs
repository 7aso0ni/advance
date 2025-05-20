using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("Notification")]
public partial class Notification
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Message { get; set; } = null!;

    [Column("NotificationTypeID")]
    public int NotificationTypeId { get; set; }

    public int? Status { get; set; }

    [ForeignKey("NotificationTypeId")]
    [InverseProperty("Notifications")]
    public virtual NotificationType NotificationType { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Notifications")]
    public virtual User User { get; set; } = null!;
}
