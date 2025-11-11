using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour //C# é fortemente Tipado
{
    public string[] itens;
    public GameObject coisa;
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
    }//feedback e gamefeel
    //IEnumerator Start()//Coroutine
    //{
    //    //Threading e AsyncOperation -> deixa lá :)

    //    //Aloca memória de trabalho
    //    //Aloca processamento
    //    //método paralelo que vai rodar no mainThread* curiosidade

    //    //obriga a existência de uma operação de suspensão
    //    //yield return new WaitForSeconds(0.1f);
    //    yield return new WaitForSeconds(0.1f);
    //    yield return new WaitUntil(()=> coisa.activeInHierarchy == true);
    //    //Desativa o inventário depois do delay

    //    //variavel do contador ;    critério (enquanto for) de encerramento ;  critério de avanço da repetição
    //    for (int variavelDeContagem = 0; variavelDeContagem < itens.Length; variavelDeContagem++) //for, while, switch "laços de repetição"
    //    {
    //        Debug.Log(itens[variavelDeContagem]);//0 //1 //2 // 3 //4! ponto de parada
    //    }

    //}

    //

    /*
        itens {"Mochila", "Picareta", "Pá", "Lanterna"}  (4 elementos, o maior índice é 3)
        itens[0]
     */
}
//classe de entidade genérica