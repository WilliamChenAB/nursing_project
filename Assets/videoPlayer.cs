using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

using UnityEngine.SceneManagement;
public class videoPlayer : MonoBehaviour
{
    //public RawImage rawImage;
    public VideoPlayer video;
    //public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(PlayVideo());
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

    public void OnClickPlay()
    {
        video.Play();
    }

    public void OnClickPause()
    {
        video.Pause();
    }

    public void OnClickReturn()
    {
        StartCoroutine(LoadYourAsyncScene());
    }

    //IEnumerator PlayVideo()
    //{
    //    video.Prepare();
    //    WaitForSeconds waitForSeconds = new WaitForSeconds(1);
    //    while (video.isPrepared)
    //    {
    //        yield return waitForSeconds;
    //        break;
    //    }
    //    rawImage.texture = video.texture;
    //    video.Play();
    //    audioSource.Play();
    //    Debug.Log("coroutine");
    //}
}
