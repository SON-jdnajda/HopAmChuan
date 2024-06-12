using System;
using System.Collections.Generic;

namespace WebChord.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<SongCategory> SongCategories { get; set; } = new List<SongCategory>();
}
