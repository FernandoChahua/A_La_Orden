﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Entity
{
    public class Sede
    {
        public int IdSede { get; set; }
        [Required(ErrorMessage = "Por favor ingrese una dirección válida")]
        public string Direccion { get; set; }
        public Franquicia Franquicia { get; set; }

    }
}
