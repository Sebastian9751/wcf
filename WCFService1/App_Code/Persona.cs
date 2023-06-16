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
    
    public int id { get; set; }
    
    public string name { get; set; }
   
    public string lastname { get; set; }
   
    public string curp{ get; set; }
  
    public string rfc { get; set; }

   
    public string email { get; set; }


    public int numero_empleado { get; set; }

   
    public DateTime fechaNacimiento { get; set; }

   
    public string password { get; set; }


}