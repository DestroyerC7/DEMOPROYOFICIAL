﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMOPROY1.Models
{
    internal class DefensaExterna
    {
        public int Id_DefensaExterna { get; set; }
        public DateTime FechaDefensaExterna { get; set; }
        public bool Aprobado { get; set; }
        public bool Calficacion { get; set; }
        public int Id_Tribunal1 { get; set; }
        public int Id_Tribunal2 { get; set; }
        public int Id_Tribunal3 { get; set; }
        public int Id_Tribunal4 { get; set; }
        public int Id_Tribunal5 { get; set; }
        public int Id_Proyecto { get; set; }
        public int Id_DefensaInterna { get; set; }

        public Tribunal Tribunal1 { get; set; }
        public Tribunal Tribunal2 { get; set; }
        public Tribunal Tribunal3 { get; set; }
        public Tribunal Tribunal4 { get; set; }
        public Tribunal Tribunal5 { get; set; }
        public Proyecto Proyecto { get; set; }
        public DefensaInterna DefensaInterna { get; set; }
    }
}
