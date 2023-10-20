using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Class06.Models;

[Table("student")]
public partial class Student
{
    [Key]
    [Column("number")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)] //para não ser identity
    public int Number { get; set; }

    [Column("name")]
    [StringLength(200)]
    public string Name { get; set; } = null!;

    [Column("classId")]
    public int? ClassId { get; set; }

    [ForeignKey("ClassId")]
    [InverseProperty("Students")]
    public virtual Class? Class { get; set; }
}
