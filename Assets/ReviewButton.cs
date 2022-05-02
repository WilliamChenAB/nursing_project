using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class ReviewButton : MonoBehaviour
{
    public GameObject reviewMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        OnClickFileCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickFileCount()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.streamingAssetsPath);
        print("Streaming Assets Path: " + Application.streamingAssetsPath);
        FileInfo[] allFiles = directoryInfo.GetFiles("*.mp4");
        int count = allFiles.Length;
        Debug.Log(count);
        if (count == 0)
        {
            reviewMenu.SetActive(false);
        }
        else
        {
            reviewMenu.SetActive(true);
        }
    }
}
