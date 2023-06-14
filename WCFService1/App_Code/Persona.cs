using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Persona
/// </summary>
public class Persona
{
    
    public int Id { get; set; }
    
    public string Name { get; set; }
   
    public string Lastname { get; set; }
   
    public string CURP { get; set; }
  
    public string RFC { get; set; }

   
    public string email { get; set; }


    public int numero_empleado { get; set; }

   
    public DateTime FechaNacimiento { get; set; }

   
    public string password { get; set; }


}