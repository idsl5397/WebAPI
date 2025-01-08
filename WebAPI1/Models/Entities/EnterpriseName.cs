using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPI1.Entities;

public partial class EnterpriseName
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string enterprise { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? code { get; set; } = null!;

    [InverseProperty("Enterprise")]
    public virtual ICollection<CompanyName> CompanyNames { get; set; } = new List<CompanyName>();
}
