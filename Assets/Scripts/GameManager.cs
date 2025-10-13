using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Singleton
    //public static GameManager Instance { get; private set; }
    public static GameManager instance;

    //único na cena
    //de fácil acesso

    //persistente*

    public GameObject prefabDoPlayer;
    public Transform posicaoInicialDoPlayer;

    public int limiteDeFPS = 60;

    void Awake()
    {
        if (instance != this)
        {
            Destroy(instance);
        }
        instance = this;
    }

    void Start()
    {
        Application.targetFrameRate = limiteDeFPS;

        Instantiate(prefabDoPlayer, posicaoInicialDoPlayer.position, Quaternion.identity);
    }
    public void SavePlayerHealth(float playerHealthToSave)
    {
        PlayerPrefs.SetFloat("Health", playerHealthToSave);
    }
    public float LoadPlayerHealth()
    {
        return PlayerPrefs.GetFloat("Health");
    }
    public void GoToNextLevel()
    {
        SceneManager.LoadScene("Gameplay Level 2");
    }
    public void OpenInventory(GameObject inventory)
    {
        inventory.SetActive(true);
    }
    public void CloseInventory(GameObject inventory)
    {
        inventory.SetActive(false);
    }
    public void ToggleInventory(GameObject inventory)
    {
        bool isActive = inventory.activeInHierarchy;
        inventory.SetActive(!isActive);
    }
}