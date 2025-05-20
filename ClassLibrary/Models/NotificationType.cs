using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("Notification_Type")]
public partial class NotificationType
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [InverseProperty("NotificationType")]
    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
