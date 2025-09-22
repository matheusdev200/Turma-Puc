using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    /*
    Algoritmo: procedimento para resolver alguma coisa 
        
    Tarefa: mover o player usando o input do usuário

    Quais as variáveis: direção, velocidade, input, quem move, 
    
    Solução: detectar o input(Entrada de ação do usuário [teclado, joystick, 
    mouse, voz, acelerômetro, câmera]), usar ele pra definir a direção, acrescentar a 
    velocidade na direção e aplicar em quem move
    
    Rigidbody2D*
    Física x Não-Física
     */

    Vector3 direction;
    Transform playerTransform;
    Rigidbody2D playerPhysics;

    public float speed;

    void Start()//método que é chamado quando o jogo abre para inicializar esse script
    {
        //inicializar coisas
        //playerTransform = GetComponent<Transform>();
        playerPhysics = GetComponent<Rigidbody2D>();
    }

    //palavra-chave de acesso -> tipo de resposta / retorno do método
    //-> NomeDoMétodo (parâmetros que o método precisa) { corpo do método }
    void Update()//chamado todo frame
    {
        Move();
    }

    //Métodos Proprietários
    public void Move() //Ação que o script vai fazer 
    {
        /*
         * Solução: detectar o input(Entrada de ação do usuário [teclado, joystick, 
    mouse, voz, acelerômetro, câmera]), usar ele pra definir a direção, aplicar a 
    velocidade na direção e aplicar em quem move
         * */
        //wasd ou setinhas -> Eixo Horizontal / Vertical

        //Escopo de Variável
        direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        //playerTransform.Translate(direction * speed * Time.deltaTime);
        //transform.Translate(direction * speed * Time.deltaTime);
        //playerTransform.position += direction * speed * Time.deltaTime;

        //playerPhysics.AddForce(direction * speed * Time.deltaTime);
        playerPhysics.linearVelocity = direction * speed * Time.deltaTime;
    }
}