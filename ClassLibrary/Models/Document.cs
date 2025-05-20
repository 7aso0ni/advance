using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Models;

[Table("Document")]
public partial class Document
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FileName { get; set; } = null!;

    [Column("UserID")]
    public int UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UploadeDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FileType { get; set; } = null!;

    [MaxLength(50)]
    public byte[] StoragePath { get; set; } = null!;

    public int DocumentType { get; set; }

    [ForeignKey("DocumentType")]
    [InverseProperty("Documents")]
    public virtual DocumentType DocumentTypeNavigation { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Documents")]
    public virtual User User { get; set; } = null!;
}
