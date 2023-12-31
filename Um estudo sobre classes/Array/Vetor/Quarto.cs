﻿using System;
using System.Runtime.CompilerServices;

namespace Vetor {
    class Quarto {

        // Classe feita para armazenar os dados da array.

        public string Nome { get; set; }
        public string Email { get; set; }
                
        public Quarto(string nome, string email) { 
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return Nome + ", " + Email;
        }
    }
}
