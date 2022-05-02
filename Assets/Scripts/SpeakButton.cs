using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
    [RequireComponent(typeof(Text))]
    public class SpeakButton : MonoBehaviour
    {
        [SerializeField]
        private Text continueButtonText;
        //public bool Continue;
        //public bool Speak;
        //public bool End;

        public UnityEvent ContinueEvent;

        // Start is called before the first frame update
        void Start()
        {
            //ContinueEvent.AddListener(SetContinue);
        }

        // Update is called once per frame
        void Update()
        {
            if (DialogueLua.GetVariable("Continue").asBool)
            {
                continueButtonText.text = "Continue";
                DialogueLua.SetVariable("Continue", false);
            }
            else if(DialogueLua.GetVariable("Speak").asBool)
            {
                continueButtonText.text = "Speak";
                DialogueLua.SetVariable("Speak", false);
            }
            else if(DialogueLua.GetVariable("End").asBool)
            {
                continueButtonText.text = "End of scenario";
                DialogueLua.SetVariable("End", false);
            }
        }

        //public void SetContinue()
        //{
        //    continueButtonText.text = "Continue";
        //}
        //public void SetSpeak()
        //{
        //    continueButtonText.text = "Click to speak";
        //}
        //public void SetEnd()
        //{
        //    continueButtonText.text = "End";
        //}
    }
}
