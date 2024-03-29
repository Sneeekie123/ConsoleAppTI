﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppTI.Entities;

public class ProductEntity
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(200)")]
    public string ProductName { get; set; } = null!;

    [Required]
    [ForeignKey(nameof(PriceEntity))]

    public int PriceId { get; set; }

    public virtual PriceEntity Price { get; set; } = null!;
}
