﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_en_consola.Elementos
{
    public class Pared : GameObject
    {
        public override bool PuedoEmpujar() { return false; }
        public override char MostrarElemento() { return '#'; }
        public override bool PuedoCaminar() { return false; }
    }
}
