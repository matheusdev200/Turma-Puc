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
        //posi��o do mouse na tela
        //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Varia��o de Posi��o = Delta => Posi��o Final - Posi��o Inicial
        Vector3 mouseDirection = mousePosition - weaponPivot.position;

        mouseDirection = new Vector3(mouseDirection.x, mouseDirection.y, 0f);

        weaponPivot.up = mouseDirection;//alinha o y do weaponPivot para o resultante da dire��o do mouse

        //caso mouse estiver da metade da tela pra esquerda -> espelha o sprite
        //caso n�o -> remove o espelhamento
    }
}
