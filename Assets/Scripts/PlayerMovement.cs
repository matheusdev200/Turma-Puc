using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    /*
    Algoritmo: procedimento para resolver alguma coisa 
        
    Tarefa: mover o player usando o input do usu�rio

    Quais as vari�veis: dire��o, velocidade, input, quem move, 
    
    Solu��o: detectar o input(Entrada de a��o do usu�rio [teclado, joystick, 
    mouse, voz, aceler�metro, c�mera]), usar ele pra definir a dire��o, acrescentar a 
    velocidade na dire��o e aplicar em quem move
    
    Rigidbody2D*
    F�sica x N�o-F�sica
     */

    Vector3 direction;
    Transform playerTransform;
    Rigidbody2D playerPhysics;

    public float speed;

    void Start()//m�todo que � chamado quando o jogo abre para inicializar esse script
    {
        //inicializar coisas
        //playerTransform = GetComponent<Transform>();
        playerPhysics = GetComponent<Rigidbody2D>();
    }

    //palavra-chave de acesso -> tipo de resposta / retorno do m�todo
    //-> NomeDoM�todo (par�metros que o m�todo precisa) { corpo do m�todo }
    void Update()//chamado todo frame
    {
        Move();
    }

    //M�todos Propriet�rios
    public void Move() //A��o que o script vai fazer 
    {
        /*
         * Solu��o: detectar o input(Entrada de a��o do usu�rio [teclado, joystick, 
    mouse, voz, aceler�metro, c�mera]), usar ele pra definir a dire��o, aplicar a 
    velocidade na dire��o e aplicar em quem move
         * */
        //wasd ou setinhas -> Eixo Horizontal / Vertical

        //Escopo de Vari�vel
        direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        //playerTransform.Translate(direction * speed * Time.deltaTime);
        //transform.Translate(direction * speed * Time.deltaTime);
        //playerTransform.position += direction * speed * Time.deltaTime;

        //playerPhysics.AddForce(direction * speed * Time.deltaTime);
        playerPhysics.linearVelocity = direction * speed * Time.deltaTime;
    }
}