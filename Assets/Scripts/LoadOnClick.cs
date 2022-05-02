using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour
{
    public void OnClickLoadScene()
    {
        //Debug.Log("OnClickLoadScene");
        StartCoroutine(LoadYourAsyncScene());
        
    }

    IEnumerator LoadYourAsyncScene()
    {
        //Debug.Log("LoadYourAsyncScene");
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }


    public void EndOnClick()
    {

       // UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();
    }
}
