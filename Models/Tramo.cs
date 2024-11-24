﻿using System;
using System.Collections.Generic;

namespace Transportes_Mardones_Torres.Models;

public partial class Tramo
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Distancia { get; set; }

    public virtual ICollection<Viaje> Viajes { get; } = new List<Viaje>();
}
