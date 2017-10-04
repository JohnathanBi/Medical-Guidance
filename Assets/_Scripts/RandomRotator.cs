using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    public GameObject ObjectToRotateAround;

    public void RandomRotate() {
        int axis = Random.Range(0, 3);
        int degrees = Random.Range(0,360);
        switch (axis) {
            case 0:
                transform.RotateAround(ObjectToRotateAround.transform.position, Vector3.up, degrees);
                break;
            case 1:
                transform.RotateAround(ObjectToRotateAround.transform.position, Vector3.forward, degrees);
                break;
            case 2:
                transform.RotateAround(ObjectToRotateAround.transform.position, Vector3.right, degrees);
                break;
        }



    }
}
