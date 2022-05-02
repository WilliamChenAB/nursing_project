using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using RenderHeads.Media.AVProMovieCapture;
using UnityEditor;
using System.IO;

namespace PixelCrushers.DialogueSystem {

    public class OnClickConversation : MonoBehaviour
    {
        public Transform conversant;
        public Transform actor;
        private int characterNumber2;
        public GameObject characterRandomizer;
        public GameObject endSessionPopup;
        public GameObject menu;
        public GameObject endSessionButton;
        public GameObject reviewSessionButton;

        //public GameObject endMenu;

        public CaptureFromScreen capture;

        // Start is called before the first frame update
        void Start()
        {
            characterNumber2 = characterRandomizer.GetComponent<CharacterRandomizer>().characterNumber;
        }

        // Update is called once per frame
        void Update()
        {

        }

        IEnumerator LoadYourAsyncScene()
        {
            //Debug.Log("LoadYourAsyncScene");
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(2);

            while (!asyncLoad.isDone)
            {
                yield return null;
            }
        }

        public void OnClick1()
        {
            if (characterNumber2 == 1 || characterNumber2 == 2)
            {
                DialogueManager.StartConversation("Aggressive Copy", actor.transform, conversant.transform);
                capture.StartCapture();
            }

            if (characterNumber2 == 3)
            {
                DialogueManager.StartConversation("Aggressive", actor.transform, conversant.transform);
                capture.StartCapture();
            }


        }
        public void OnClick2()
        {
            if (characterNumber2 == 1 || characterNumber2 == 2)
            {
                DialogueManager.StartConversation("Receptive Copy", actor.transform, conversant.transform);
                capture.StartCapture();
            }

            if (characterNumber2 == 3)
            {
                DialogueManager.StartConversation("Receptive", actor.transform, conversant.transform);
                capture.StartCapture();
            }
        }
        public void OnClick3()
        {
            if (characterNumber2 == 1 || characterNumber2 == 2)
            {
                DialogueManager.StartConversation("Manipulative Copy", actor.transform, conversant.transform);
                capture.StartCapture();
            }

            if (characterNumber2 == 3)
            {
                DialogueManager.StartConversation("Manipulative", actor.transform, conversant.transform);
                capture.StartCapture();
            }
        }

        //public void OnClickEndMenu()
        //{
        //    endMenu.SetActive(true);
        //}

        public void OnClickReview()
        {
            StartCoroutine(LoadYourAsyncScene());
        }

        //stops capture after situation ends - found in dialogue manager gameobject
        public void OnClickEndCapture()
        {
            capture.StopCapture();
        }

        public void OnClickEndSession()
        {
            endSessionPopup.SetActive(true);
            menu.SetActive(false);
            endSessionButton.SetActive(false);
            reviewSessionButton.SetActive(false);
        }

        IEnumerator LoadYourAsyncStartScene()
        {
            //Debug.Log("LoadYourAsyncScene");
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(4);

            while (!asyncLoad.isDone)
            {
                yield return null;
            }
        }

        public void OnClickEndButton()
        {
            var SA = Directory.GetFiles("Assets/StreamingAssets");

            for (int i = 0; i < SA.Length; i++)
            {
                File.Delete(SA[i]);

                //Directory.Delete("Assets/StreamingAssets");
                //FileUtil.DeleteFileOrDirectory("StreamingAssets");
                //Directory.CreateDirectory("Assets/StreamingAssets");
                //endSessionPopup.SetActive(false);
               
            }
            StartCoroutine(LoadYourAsyncStartScene());
        }

        public void OnClickCancelButton()
        {
            endSessionPopup.SetActive(false);
            menu.SetActive(true);
            endSessionButton.SetActive(true);
            reviewSessionButton.SetActive(true);
        }
    }
}
