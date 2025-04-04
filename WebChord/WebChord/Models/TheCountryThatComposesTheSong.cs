﻿using System;
using System.Collections.Generic;

namespace WebChord.Models;

public partial class TheCountryThatComposesTheSong
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Song> Songs { get; set; } = new List<Song>();
}
