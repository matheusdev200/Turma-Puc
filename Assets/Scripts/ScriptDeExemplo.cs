using UnityEngine;

public class ScriptDeExemplo : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Objeto <b>carregou</b> na memória");
    }
    void Start()
    {
        Debug.Log("Objeto <b>inicializou</b>");
    }
    void OnEnable()
    {
        Debug.Log("Objeto foi <b>ativado</b>");
        //Start();//nojinho
    }
    void OnDisable()
    {
        Debug.Log("Objeto foi <b>desativado</b>");
        //gameObject.SetActive(false);
    }
    void Update()
    {
        Debug.Log("Objeto está <b>rodando</b>");
    }
}
