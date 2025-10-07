using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float currentHealth;
    public float maxHealth;

    public TextMeshProUGUI healthText;
    public GameManager gameManager;

    void Awake()
    {
        healthText = GameObject.FindGameObjectWithTag("Health Text")
            .GetComponent<TextMeshProUGUI>();

        gameManager = FindAnyObjectByType<GameManager>();
    }
    void Start()
    {
        if (gameManager.LoadPlayerHealth() == 0)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth = gameManager.LoadPlayerHealth();
        }

        //atualizando a HUD pela primeira vez
        healthText.text = "Health: " + currentHealth;//concatenação de variável com string

        //healthText.text = $"Health: {currentHealth}";

        //string healthString = "Health: " + currentHealth.ToString();
        //healthText.text = healthString;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            gameManager.SavePlayerHealth(currentHealth);
            gameManager.GoToNextLevel();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            currentHealth--;
            healthText.text = $"Health: {currentHealth}";//não esquecer de atualizar a UI para o jogador também saber que 
        }
    }
}