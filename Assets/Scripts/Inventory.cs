using UnityEngine;

public class Inventory : MonoBehaviour //C# � fortemente Tipado
{
    public string[] itens;
    //public int[] quantidadeDeItens;

    //listagem de coisas 
    //Pilha, Fila, Lista, Array / Vetor, Dicionario 
    //Estrutura de Dados

    private void Start()
    {
        //variavel do contador ;    crit�rio (enquanto for) de encerramento ;  crit�rio de avan�o da repeti��o
        for (int variavelDeContagem = 0; variavelDeContagem < itens.Length; variavelDeContagem++) //for, while, switch "la�os de repeti��o"
        {
            Debug.Log(itens[variavelDeContagem]);//0 //1 //2 // 3 //4! ponto de parada
        }
    }

    /*
     
    itens {"Mochila", "Picareta", "P�", "Lanterna"}  (4 elementos, o maior �ndice � 3)
    itens[0]

     */
}
//classe de entidade gen�rica