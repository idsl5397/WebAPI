using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPI1.Entities;

[Index("CompanyId", Name = "IX_FactoryNames_CompanyId")]
public partial class FactoryName
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    public string factory { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdateAt { get; set; }

    public int? CompanyId { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("FactoryNames")]
    public virtual CompanyName? Company { get; set; }
}
