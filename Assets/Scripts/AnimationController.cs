using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Puppet3D;

[CreateAssetMenu(fileName = "AnimationController")]
public class AnimationController : ScriptableObject
{
    private GameObject npc;
    public RuntimeAnimatorController walk;
    public RuntimeAnimatorController angry;
    public RuntimeAnimatorController neutral;
    public RuntimeAnimatorController sad;
    private int characterNumber2;
    private GameObject characterRandomizer;
    // Start is called before the first frame update
    void Start()
    {
        characterRandomizer = GameObject.Find("Character Randomizer");
        characterNumber2 = characterRandomizer.GetComponent<CharacterRandomizer>().characterNumber;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    public void OnExecuteWalk()
    {
        if (characterNumber2 == 1)
        {
            npc = GameObject.Find("Medical_Girl_1");
            Animator controller = npc.GetComponent<Animator>();
            controller.runtimeAnimatorController = walk as RuntimeAnimatorController;
        }

        if (characterNumber2 == 2)
        {
            npc = GameObject.Find("Medical_Girl_2");
            Animator controller = npc.GetComponent<Animator>();
            controller.runtimeAnimatorController = walk as RuntimeAnimatorController;
        }

        if (characterNumber2 == 3)
        {
            npc = GameObject.Find("Medical_Guy_6");
            Animator controller = npc.GetComponent<Animator>();
            controller.runtimeAnimatorController = walk as RuntimeAnimatorController;
        }
    }
    */

    public void OnExecuteAngry()
    {

        //if (characterNumber2 == 1)
        //{
        //    npc = GameObject.Find("Medical_Girl_1");
        //    Animator controller = npc.GetComponent<Animator>();
        //    controller.runtimeAnimatorController = angry as RuntimeAnimatorController;
        //}

        //if (characterNumber2 == 2)
        //{
        //    npc = GameObject.Find("Medical_Girl_2");
        //    Animator controller = npc.GetComponent<Animator>();
        //    controller.runtimeAnimatorController = angry as RuntimeAnimatorController;
        //}

        //if (characterNumber2 == 3)
        //{
        //    npc = GameObject.Find("Medical_Guy_6");
        //    Animator controller = npc.GetComponent<Animator>();
        //    controller.runtimeAnimatorController = angry as RuntimeAnimatorController;
        //}

        npc = GameObject.FindGameObjectWithTag("Player");
        Animator controller = npc.GetComponent<Animator>();
        controller.runtimeAnimatorController = angry as RuntimeAnimatorController;

    }

    public void OnExecuteNeutral()
    {
        //if (characterNumber2 == 1)
        //{
        //    npc = GameObject.Find("Medical_Girl_1");
        //    Animator controller = npc.GetComponent<Animator>();
        //    controller.runtimeAnimatorController = neutral as RuntimeAnimatorController;
        //}

        //if (characterNumber2 == 2)
        //{
        //    npc = GameObject.Find("Medical_Girl_2");
        //    Animator controller = npc.GetComponent<Animator>();
        //    controller.runtimeAnimatorController = neutral as RuntimeAnimatorController;
        //}

        //if (characterNumber2 == 3)
        //{
        //    npc = GameObject.Find("Medical_Guy_6");
        //    Animator controller = npc.GetComponent<Animator>();
        //    controller.runtimeAnimatorController = neutral as RuntimeAnimatorController;
        //}

        npc = GameObject.FindGameObjectWithTag("Player");
        Animator controller = npc.GetComponent<Animator>();
        controller.runtimeAnimatorController = neutral as RuntimeAnimatorController;
    }

    public void OnExecuteSad()
    {
        //Debug.Log("sad function");
        //Debug.Log(characterNumber2);

        //if (characterNumber2 == 1)
        //{
        //    npc = GameObject.Find("Medical_Girl_1");
        //    Animator controller = npc.GetComponent<Animator>();
        //    controller.runtimeAnimatorController = sad as RuntimeAnimatorController;
        //    Debug.Log("sad");
        //}

        //if (characterNumber2 == 2)
        //{
        //    npc = GameObject.Find("Medical_Girl_2");
        //    Animator controller = npc.GetComponent<Animator>();
        //    controller.runtimeAnimatorController = sad as RuntimeAnimatorController;
        //    Debug.Log("sad");
        //}

        //if (characterNumber2 == 3)
        //{
        //    npc = GameObject.Find("Medical_Guy_6");
        //    Animator controller = npc.GetComponent<Animator>();
        //    controller.runtimeAnimatorController = sad as RuntimeAnimatorController;
        //    Debug.Log("sad");
        //}

        npc = GameObject.FindGameObjectWithTag("Player");
        Animator controller = npc.GetComponent<Animator>();
        controller.runtimeAnimatorController = sad as RuntimeAnimatorController;
        

    }
}
