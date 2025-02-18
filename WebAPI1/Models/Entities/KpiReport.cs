using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPI1.Entities;

// [Index("KpiDataId", Name = "IX_KpiReports_KpiDataId")]
public class KpiReport
{
    [Key]
    public int Id { get; set; }
    
    [Range(0, 10)]
    public int Year { get; set; }
    
    [Range(0, 10)]
    public int KpiReportValue { get; set; }
    
    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdateAt { get; set; }
    
    // public int? KpiDataId { get; set; }
    //
    // [ForeignKey("KpiDataId")]
    // [InverseProperty("KpiReports")]
    // public virtual KpiData? KpiData { get; set; }
}