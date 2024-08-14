using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolCar_Api.Models;

public partial class Zadanium
{
    public int ZadId { get; set; }

    public string? ZadNaglowek { get; set; }

    public string? ZadOpis { get; set; }
    [ForeignKey("Zad_Priorytet")]
    public virtual int ZadPriorytet { get; set; }

    public int? ZadStatus { get; set; }
    [ForeignKey("Zad_pracownik")]
    public virtual int ZadPracownik { get; set; }
    public DateTime Zad_Data { get; set; }


}
