using System;
using System.Collections.Generic;

namespace Transportes_Mardones_Torres;

public partial class Bus
{
    public int Id { get; set; }

    public string Patente { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public bool Disponibilidad { get; set; }

    public virtual ICollection<Chofer> Chofers { get; } = new List<Chofer>();

    public virtual ICollection<Viaje> Viajes { get; } = new List<Viaje>();
}
