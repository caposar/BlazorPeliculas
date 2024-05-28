﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPeliculas.Shared.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; } = null!;
        public List<GeneroPelicula> GenerosPelicula { get; set; } = new List<GeneroPelicula>();
    }
}
