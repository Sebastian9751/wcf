using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Items
/// </summary>
public class Items

{
    public int id { get; set; }

    public string nombreItem { get; set; }

    public string description { get; set; }



    public bool status { get; set; }

}
