using Unity.FPS.Game;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Unity.FPS.UI
{

    public class BackToTitle : MonoBehaviour
    {
        public GameObject InGameMenuManager;
        public string SceneName = "";

        void Update()
        {
            /*if (EventSystem.current.currentSelectedGameObject == gameObject
                && Input.GetButtonDown(GameConstants.k_ButtonNameSubmit))
            {
                Debug.Log("Button clicked");
                InGameMenuManager.GetComponent<InGameMenuManager>().isBackToTitle = true;
                //LoadTargetScene();

            }*/
        }

        public void BackTitle()
        {
            Debug.Log("Button clicked");
            InGameMenuManager.GetComponent<InGameMenuManager>().isBackToTitle = true;
            //SceneManager.LoadScene(SceneName);
        }
    }
}