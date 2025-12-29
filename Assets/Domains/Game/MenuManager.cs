//using UnityEngine;
//namespace Domains{
//    public class MenuManager : MonoBehaviour
//    {
//        public void ChangeScene(string name)
//        {
//            EventBus<OnChangeScene>.Raise(new OnChangeScene { sceneName = name });
//        }
//        public void QuitGame()
//        {
//            Debug.Log("Quit game");
//            Application.Quit();
//        }

//        //Refatorar Depois
//        public void TogglePanelVisibility(GameObject panel)
//        {
//            panel.SetActive(!panel.activeInHierarchy);
//        }
//        public void SetPanelVisible(GameObject panel)
//        {
//            panel.SetActive(true);
//        }
//        public void SetPanelInvisible(GameObject panel)
//        {
//            panel.SetActive(false);
//        }

//        public void ContinueButton()
//        {
//            EventBus<OnSetPauseState>.Raise(new OnSetPauseState { nextPauseState = false });
//        }
//        public void QuitGameButton()
//        {
//            EventBus<OnChangeScene>.Raise(new OnChangeScene { sceneName = "Main Menu Scene" });
//        }
//    }
//}