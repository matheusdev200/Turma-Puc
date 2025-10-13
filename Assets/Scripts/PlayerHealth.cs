using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float currentHealth;
    public float maxHealth;

    public TextMeshProUGUI healthText;

    void Awake()
    {
        healthText = GameObject.FindGameObjectWithTag("Health Text")
            .GetComponent<TextMeshProUGUI>();
    }
    void Start()
    {
        if (GameManager.instance.LoadPlayerHealth() == 0)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth = GameManager.instance.LoadPlayerHealth();
        }

        //atualizando a HUD pela primeira vez
        healthText.text = "Health: " + currentHealth;//concatena��o de vari�vel com string

        //healthText.text = $"Health: {currentHealth}";

        //string healthString = "Health: " + currentHealth.ToString();
        //healthText.text = healthString;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameManager.instance.SavePlayerHealth(currentHealth);
            GameManager.instance.GoToNextLevel();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            currentHealth--;
            healthText.text = $"Health: {currentHealth}";//n�o esquecer de atualizar a UI para o jogador tamb�m saber que 
        }
    }
}