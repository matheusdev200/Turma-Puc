using UnityEngine;
using UnityEngine.InputSystem;

public class MouseAim : MonoBehaviour
{
    public EnemyState state;

    public Transform weaponPivot;
    void Update()
    {
        RotateWeaponWithMouse();
    }
    void RotateWeaponWithMouse()
    {
        //posição do mouse na tela
        //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Variação de Posição = Delta => Posição Final - Posição Inicial
        Vector3 mouseDirection = mousePosition - weaponPivot.position;

        mouseDirection = new Vector3(mouseDirection.x, mouseDirection.y, 0f);

        weaponPivot.up = mouseDirection;//alinha o y do weaponPivot para o resultante da direção do mouse

        //caso mouse estiver da metade da tela pra esquerda -> espelha o sprite
        //caso não -> remove o espelhamento
    }
}

/*
 Inimigo
            Máquina de Estados - OK

        Item Coletável - OK
            Criação e Remoção de coisas da cena - OK
            Trigger - OK
            Interação de Input do Jogador +- OK

            Scriptable Object

        Inventário
            Estrutura de Dados

        Interface
            Canvas

        Git

        Herança e Polimorfismo

//desacoplado
//reutilizável

//genérico

 */