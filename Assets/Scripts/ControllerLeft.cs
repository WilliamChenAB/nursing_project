using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.WSA;

[RequireComponent(typeof(Transform))]
public class ControllerLeft : MonoBehaviour
{
    [SerializeField] private Transform cube;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube.SetPositionAndRotation(InputTracking.GetLocalPosition(XRNode.TrackingReference) - InputTracking.GetLocalPosition(XRNode.LeftHand), InputTracking.GetLocalRotation(XRNode.LeftHand));
    }
}
