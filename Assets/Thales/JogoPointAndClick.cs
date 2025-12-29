using UnityEngine;
using System;

public class JogoPointAndClick : MonoBehaviour
{
    //Progresso do jogador
    public GameObject[] cenas = new GameObject[3];//inicializar um Array
                                                  //vetor de 1 dimensao que guarda GameObjects

    [SerializeField] int currentLevel = 0;
    public static int cats = 0;
    //string currentScene = "Cena 1";

    //problemas: evento para mais de um gato,
    //mudando de cenas, como representar o progresso do player

    //salvamento -> persistência de dados
    //Salvamento via PlayerPrefs  x Salvamento via JSON 

    #region Declaracao de Eventos

    //simplificação dos tipos delegados
    //listener and observer pattern
    public static Action OnFindGreenCat;//trigger
    //declaração da tarefa de OnFindGreenCat
    public static Action OnFindRedCat;
    public static Action OnPlayerDefeated;

    #endregion Declaracao de Eventos

    void Update()
    {
        if (currentLevel == 0 || currentLevel == 1)
        {
            if (cats == 1)
            {
                Debug.Log("Jogador venceu o level, passa pro próximo");
                //currentLevel++;//incrementa currentLevel em 1 unidade
                //currentLevel = currentLevel+ 1;
                cenas[currentLevel].SetActive(false);//desliga a fase atual
                currentLevel += 1; //move o jogo uma fase pra frente
                cenas[currentLevel].SetActive(true);//liga a fase nova
                cats = 0; //reinicia o contador de gatos

                PlayerPrefs.SetInt("Saved Level", currentLevel);//salva a fase nova

                //usa o contador -> atualiza o contador -> usa o contador de novo
            }
        }
        if (currentLevel == 2)
        {
            if (cats == 2)
            {
                Debug.Log("Fim de jogo!");
            }
        }
    }
    public void BotaoDoGatoVermelho()
    {
        OnFindRedCat?.Invoke();
    }
    public void BotaoDoGatoVerde()//quando o jogador encontrar E clicar no gato verde
    {
        OnFindGreenCat?.Invoke();//? -> verifica se está vazio OU indica que PODE SER vazio
    }
    public void AbrirCena(int cenaSelecionada)
    {
        cenas[cenaSelecionada].SetActive(true);
        PlayerPrefs.SetInt("Saved Level", cenaSelecionada);
    }
    public void FecharCena(int cenaSelecionada)
    {
        cenas[cenaSelecionada].SetActive(false);
    }
    public void Continuar()
    {
        currentLevel = PlayerPrefs.GetInt("Saved Level");
        cenas[currentLevel].SetActive(true);//ligar a fase carregada
    }
}