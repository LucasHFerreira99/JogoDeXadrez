﻿using System.Reflection.Metadata.Ecma335;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }


        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QtdMovimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();

        public void IncrementarQtdMovimentos()
        {
            QtdMovimentos++;
        }
    }

}
