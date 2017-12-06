﻿using tabuleiro;
using System;
using xadrez;

namespace xadrez{
    class Rei : Peca {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString(){
        
                return "R";
            }
        }
    }

