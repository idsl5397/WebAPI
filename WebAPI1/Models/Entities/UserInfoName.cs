using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAPI1.Entities;

public class UserInfoName
{
    [Key]
    public int Id { get; set; }
    [Column("username", TypeName = "nvarchar(25)")]
    public string Username { get; set; }

    [Column("password", TypeName = "nvarchar(max)")]
    public string Password { get; set; }

    [Column("nickname", TypeName = "nvarchar(50)")]
    public string Nickname { get; set; }

    public int? EnterpriseId { get; set; }
    public int? CompanyId { get; set; }
    public int? FactoryId { get; set; }

    [Column("authority", TypeName = "nvarchar(max)")]
    public string Authority { get; set; }
    
    [Column("mobile", TypeName = "varchar(40)")]
    public string? Mobile { get; set; }

    [Column("email", TypeName = "varchar(max)")]
    public string? Email { get; set; }

    public byte[] Salt { get; set; }
    
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdateAt { get; set; }

}