//using UnityEngine;

//public class StartGame : MonoBehaviour
//{
//    public float startGameDelay = 1f;
//    public string firstSceneName;
//    void Start()
//    {
//        Invoke("BeginGame", startGameDelay);
//    }
//    void BeginGame()
//    {
//        EventBus<OnStartGame>.Raise(new OnStartGame { firstScene = this.firstSceneName });
//    }
//}