//using Domains.UI;
//using System.Collections;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//namespace Domains
//{
//    public class SceneMaster : MonoBehaviour
//    {
//        //Bindings
//        EventBinding<OnStartGame> startGame;
//        EventBinding<OnChangeScene> changeScene;
//        EventBinding<OnAddScene> addScene;
//        EventBinding<OnRemoveScene> removeScene;

//        public AsyncOperation addingSceneOperation;
//        public AsyncOperation removingSceneOperation;

//        void OnEnable()
//        {
//            startGame = new EventBinding<OnStartGame>(SimpleStartGame);
//            EventBus<OnStartGame>.Register(startGame);

//            changeScene = new EventBinding<OnChangeScene>(SimpleChangeScene);
//            EventBus<OnChangeScene>.Register(changeScene);

//            addScene = new EventBinding<OnAddScene>(AddScene);
//            EventBus<OnAddScene>.Register(addScene);

//            removeScene = new EventBinding<OnRemoveScene>(RemoveScene);
//            EventBus<OnRemoveScene>.Register(removeScene);
//        }
//        void OnDisable()
//        {
//            EventBus<OnStartGame>.Deregister(startGame);
//            EventBus<OnChangeScene>.Deregister(changeScene);
//            EventBus<OnAddScene>.Deregister(addScene);
//            EventBus<OnRemoveScene>.Deregister(removeScene);
//        }
//        public void SimpleStartGame(OnStartGame currentEvent)
//        {
//            SceneManager.LoadScene(currentEvent.firstScene);
//        }
//        public void SimpleChangeScene(OnChangeScene currentEvent)
//        {
//            SceneManager.LoadScene(currentEvent.sceneName);
//        }
//        public void AddScene(OnAddScene currentEvent)
//        {
//            //gambiarra, refatorar depois
//            StartCoroutine(AddSceneRoutine(currentEvent.sceneName));
//        }
//        IEnumerator AddSceneRoutine(string sceneName)
//        {
//            addingSceneOperation = SceneManager.LoadSceneAsync(sceneName
//                    , LoadSceneMode.Additive);
//            addingSceneOperation.allowSceneActivation = false;

//            EventBus<OnFade>.Raise(new OnFade { fade = FadeType.FadeOut });

//            yield return new WaitForSeconds(Fade.instance.fadeTime + 0.1f);

//            EventBus<OnFade>.Raise(new OnFade { fade = FadeType.FadeIn });
//            addingSceneOperation.allowSceneActivation = true;
//        }
//        public void RemoveScene(OnRemoveScene currentEvent)
//        {
//            //gambiarra, refatorar depois
//            StartCoroutine(RemoveSceneRoutine(currentEvent.sceneName));
//        }
//        IEnumerator RemoveSceneRoutine(string sceneName)
//        {
//            removingSceneOperation = SceneManager.UnloadSceneAsync(sceneName);
//            yield return new WaitUntil(() => removingSceneOperation.isDone == true);
//            SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(2));
//            EventBus<OnFade>.Raise(new OnFade { fade = FadeType.FadeIn });
//            GameManager.Instance.ActivatePlayerCar();
//        }
//    }
//}