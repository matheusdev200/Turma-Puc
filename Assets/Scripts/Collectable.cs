using UnityEngine;

public class Collectable : MonoBehaviour
{
    private Player player;

    //ao ENTRAR na �rea de trigger
    private void OnTriggerEnter2D(Collider2D objectThatEntered)
    {
        //if (objectThatEntered.tag == "Jogador")//nojinho :(
        if (objectThatEntered.CompareTag("Jogador"))//:)
        {
            player = objectThatEntered.GetComponent<Player>();
        }
    }
    //caso FIQUE na �rea de trigger
    private void OnTriggerStay2D(Collider2D objectThatStayed)
    {
        if (objectThatStayed.CompareTag("Jogador") && player.interact)
        {
            //realiza a a��o do colet�vel
            //deleta ele da cena
            //Debug.Log("Player pegou o coletavel");
            Destroy(gameObject, 0.15f);
        }
    }
    //ao SAIR da �rea de trigger
    private void OnTriggerExit2D(Collider2D objectThatExit)
    {
        if (objectThatExit.CompareTag("Jogador"))
        {
            //Debug.Log("Jogador saiu da �rea");
            player = null;
        }
    }
}