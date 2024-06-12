using System;
using System.Collections.Generic;

namespace WebChord.Models;

public partial class ChordGroup
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Chord> Chords { get; set; } = new List<Chord>();
}
