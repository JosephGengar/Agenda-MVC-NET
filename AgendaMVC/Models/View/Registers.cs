﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendaMVC.Models.View
{
    public class Registers
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
}