using UnityEngine;

public class Inventory : MonoBehaviour //C# é fortemente Tipado
{
    public string[] itens;
    //public int[] quantidadeDeItens;

    //listagem de coisas 
    //Pilha, Fila, Lista, Array / Vetor, Dicionario 
    //Estrutura de Dados

    private void Start()
    {
        //variavel do contador ;    critério (enquanto for) de encerramento ;  critério de avanço da repetição
        for (int variavelDeContagem = 0; variavelDeContagem < itens.Length; variavelDeContagem++) //for, while, switch "laços de repetição"
        {
            Debug.Log(itens[variavelDeContagem]);//0 //1 //2 // 3 //4! ponto de parada
        }
    }

    /*
     
    itens {"Mochila", "Picareta", "Pá", "Lanterna"}  (4 elementos, o maior índice é 3)
    itens[0]

     */
}
//classe de entidade genérica