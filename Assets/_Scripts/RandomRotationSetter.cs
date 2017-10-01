using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotationSetter : MonoBehaviour {

    public GameObject TargetWand;


    private SteamVR_TrackedObject trackedObj;

    private SteamVR_Controller.Device Controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    public void Update(){
        if (Controller.GetHairTriggerDown()) {
            TargetWand.GetComponent<RandomRotator>().RandomRotate();
        }

    }
}
