using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PolCar_Api.Models;

public partial class Priorytet
{
    public int PriId { get; set; }

    public string? PriNazwa { get; set; }

    public string? PriOpis { get; set; }
    [JsonIgnore]
    public virtual ICollection<Zadanium> Zadania { get; set; } = new List<Zadanium>();
}
