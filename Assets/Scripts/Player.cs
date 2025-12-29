using UnityEngine;

public class Player : MonoBehaviour
{
    public bool interact = false;

    public ScriptDeExemplo exemplo;
    bool scriptAtivado = true;

    void Update()
    {
        //interact = Input.GetKeyDown(KeyCode.E);
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            scriptAtivado = !scriptAtivado;
            exemplo.enabled = scriptAtivado;
        }
    }
}
