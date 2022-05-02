using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using UnityEngine.UI;

using RenderHeads.Media.AVProMovieCapture;
using RenderHeads.Media.AVProVideo;

public class VideoLoader : MonoBehaviour
{
    private MediaPlayer.FileLocation videoLocation = MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder;
    public MediaPlayer myMediaPlayer;
    public Dropdown dropdown;
    // Start is called before the first frame update
    void Start()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(Application.streamingAssetsPath);
        print("Streaming Assets Path: " + Application.streamingAssetsPath);
        FileInfo[] allFiles = directoryInfo.GetFiles("*.mp4");
        //List <string> options = directoryInfo.GetFiles("*.*");
        //Debug.Log(allFiles);

        List<string> filenames = new List<string>();
        //filenames = filenames.Reverse();
        

        foreach (FileInfo file in allFiles)
        {
            //Debug.Log(file.ToString());
            //dropdown.AddOptions(new Dropdown.OptionData(file.Name));
            filenames.Add(file.Name);
        }

        filenames.Reverse();
        dropdown.AddOptions(filenames);

        //for (FileInfo data : allFiles)
        //{
        //    dropdown.AddOptions(new Dropdown.OptionData(data.Name));

        //}


    }

    public void OnClickLoad()
    {
        myMediaPlayer.OpenVideoFromFile(videoLocation, dropdown.options[dropdown.value].text, true);
        dropdown.gameObject.SetActive(false);
    }

    public void OnClickBrowse()
    {
        dropdown.gameObject.SetActive(true);
    }

    public void OnClickForward()
    {
        float timenow = myMediaPlayer.Control.GetCurrentTimeMs();
        myMediaPlayer.Control.Seek(timenow + 5000);
    }

    public void OnClickBack()
    {
        float timenow = myMediaPlayer.Control.GetCurrentTimeMs();
        myMediaPlayer.Control.Seek(timenow - 5000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
