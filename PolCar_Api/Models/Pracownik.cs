using System;
using System.Collections.Generic;

namespace PolCar_Api.Models;

public partial class Pracownik
{
    public int PraId { get; set; }

    public string? PraNazwa { get; set; }

    public int PraPraRid { get; set; }

    public int? PraSzef { get; set; }

    public virtual PracownikRola PraPraR { get; set; } = null!;

    public virtual ICollection<Zadanium> Zadania { get; set; } = new List<Zadanium>();
}
