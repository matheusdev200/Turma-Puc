using UnityEngine;

public class GatoVerde : MonoBehaviour//representa um player hipotético
{
    //status
    public int pv = 3;
    public int ataque = 0;

    void OnEnable()
    {
        JogoPointAndClick.OnFindGreenCat += AcaoDoGatoVerde;
        JogoPointAndClick.OnFindRedCat += AcaoDoGatoVermelho;//+= é acrescentar ao cadastro
    }
    void OnDisable()
    {
        JogoPointAndClick.OnFindGreenCat -= AcaoDoGatoVerde;
        JogoPointAndClick.OnFindRedCat -= AcaoDoGatoVermelho;//-= é remover do cadastro
    }

    //responsável por realizar a ação quando o Evento de OnFindGreenCat acontecer
    public void AcaoDoGatoVerde()//ação é a resposta pra quando o evento acontecer 
    {
        Debug.Log("Clicou no Gato Verde", gameObject);
        //pv += 1;
        //ataque += 1;
        JogoPointAndClick.cats++;
    }
    public void AcaoDoGatoVermelho()
    {
        pv -= 1;
        //verifica se ele perdeu
        if (pv <= 0)
        {
            Debug.Log("E morreu");
            //evento de player derrotado (OnPlayerDefeated)
        }
    }
    //private void OnTriggerStay2D(Collider2D other)
    //{
    //    if (/*other.tag == "Jogador"*/)
    //    {
    //        if (/*jogador apertou x tecla*/)
    //        {
    //            if (/*jogador virado pra direita*/) 
    //            {
    //            
    //            }
    //        }
    //    }
    //}
}
