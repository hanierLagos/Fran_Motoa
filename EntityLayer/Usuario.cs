﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Usuario
    {
        public int ID_USUARIO {  get; set; }    
        public string CODIGO_USUARIO { get; set; }
        public string  ROL {  get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string USUARIO { get; set; }
        public string CONTRASENA { get; set; }

    }
}