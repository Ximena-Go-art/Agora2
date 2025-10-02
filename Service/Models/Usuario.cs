﻿using Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public int Dni { get; set; }
        public string Email { get; set; } = string.Empty;
        public TipoUsuarioEnum TipoUsuario { get; set; } = TipoUsuarioEnum.Estudiante;
        public DateTime DeleteDate { get; set; } = DateTime.MinValue;
        public bool IsDeleted { get; set; } = false;

        public override string ToString()
        {
            return Nombre;
        }
    }
}
