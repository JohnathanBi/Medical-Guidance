using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    public void RandomRotate() {
        int axis = Random.Range(0, 3);
        int degrees = Random.Range(0,360);
        switch (axis) {
            case 0:
                transform.RotateAround(transform.parent.transform.position, Vector3.up, degrees);
                break;
            case 1:
                transform.RotateAround(transform.parent.transform.position, Vector3.forward, degrees);
                break;
            case 2:
                transform.RotateAround(transform.parent.transform.position, Vector3.right, degrees);
                break;
        }


       // Debug.Log(Vector3.Distance(transform.position, transform.parent.transform.position));

        //transform.LookAt(transform.parent.transform.position);
    }
}
