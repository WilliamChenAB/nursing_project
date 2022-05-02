using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using CrazyMinnow.SALSA;
//using RenderHeads.Media.AVProMovieCapture;

[CreateAssetMenu(fileName = "AudioScriptableObject")]
public class AudioScriptableObject : ScriptableObject
{

    //private Salsa3D salsa;
    //private Salsa3D salsaTeeth;
    //public GameObject npc;

    public AudioClip[] audioClips;

    //private AudioSource source;

    public void PlayAudioClip(int i)
    {
        //salsa = GameObject.Find("Oscar_LOD0").GetComponent<Salsa3D>();
        //salsa = GameObject.Find("H_DDS_HighRes").GetComponent<Salsa3D>();
        //salsaTeeth = GameObject.Find("h_TeethDown").GetComponent<Salsa3D>();
        //salsa = npc.GetComponent<Salsa3D>();
        //salsa.SetAudioClip(audioClips[i]);
        //salsaTeeth.SetAudioClip(audioClips[i]);
        //salsaTeeth.Play();
        //salsa.SetAudioClip(audioClips[i]);
        //salsa.Play(); 
        //AudioSource.PlayClipAtPoint(audioClips[i], Vector3.zero);
        //Debug.Log("Play Audio");
   
        GameObject SALSA = GameObject.Find("Audio Source");
        AudioSource source = SALSA.GetComponent<AudioSource>();
        source.clip = audioClips[i];
        source.Play();

    }
}
