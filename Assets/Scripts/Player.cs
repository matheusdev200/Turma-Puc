using UnityEngine;

public class Player : MonoBehaviour
{
    public bool interact = false;
    void Update()
    {
        interact = Input.GetKeyDown(KeyCode.E);
    }
}
