using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RenderHeads.Media.AVProMovieCapture;

public class RecorderController : MonoBehaviour
{
    public CaptureFromScreen capture;
    
    // Start is called before the first frame update
    void Start()
    {
        capture.StartCapture();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
