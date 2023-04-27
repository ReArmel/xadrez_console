﻿namespace tabuleiro;

 abstract class Peca
{
    public Posicao posicao { get; set; }
    public Cor cor { get; protected set; }
    public int qteMovimentos { get; protected set; }
    public Tabuleiro tab { get; protected set; }

    public Peca(Tabuleiro tab, Cor cor)
    {
        this.posicao = null;
        this.cor = cor;
        this.tab = tab;
        this.qteMovimentos = 0;
    }

    public void incrementarQteMovimentos()
    {
        qteMovimentos++;
    }
    // Fazendo essa matriz de valores booleanos consigo marcar verdadeiro onde for possível fazer os moviemntos das peças e falso onde não é possível.
    //Usei o método abstrato pois essa classe, por ser genérica, não vou fazer nenhuma implementação. A regra de movimento depende de cada peça específica. Sendo assim alterei minha classe para abstrata também (pois qdo a classe tem pelo menos um método abstrato ela se torna abstrata também).
    public abstract bool[,] movimentosPossiveis();
      
}
