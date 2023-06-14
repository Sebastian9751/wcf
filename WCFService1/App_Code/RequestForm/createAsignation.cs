using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de createAsignation
/// </summary>
public class createAsignation
{
    public int id_persona { get; set; }
    public int itemId { get; set; }
    public DateTime dia_asignacion { get; set; }
    public DateTime dia_entrega { get; set; }
    public DateTime dia_liberacion { get; set; }
}