using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject prefabDoPlayer;
    public Transform posicaoInicialDoPlayer;

    public int limiteDeFPS = 60;

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
}