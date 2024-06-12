using System;
using System.Collections.Generic;

namespace WebChord.Models;

public partial class SongUser
{
    public int Id { get; set; }

    public int? IdSong { get; set; }

    public int? IdUser { get; set; }

    public virtual Song? IdSongNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
