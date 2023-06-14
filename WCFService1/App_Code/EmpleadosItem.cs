using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EmpleadosItem
/// </summary>
public class EmpleadosItem
{
    public int id { get; set; }
    public int id_persona { get; set; }
    public int id_item { get; set; }
    public DateTime dia_asignacion { get; set; }
    public DateTime dia_entrega { get; set; }
    public DateTime dia_liberacion { get; set; }
    public Person persona { get; set; }
    public Items items { get; set; }
}

public class Person
{
    public int id { get; set; }
    public string name { get; set; }
    public string lastname { get; set; }
    public string curp { get; set; }
    public string rfc { get; set; }
    public string email { get; set; }
    public int numero_empleado { get; set; }
    public DateTime fechaNacimiento { get; set; }
}