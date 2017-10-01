using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtRotator : MonoBehaviour {

    public  GameObject LookAtObject;
	
	void Update () {
        this.transform.LookAt(LookAtObject.transform);
	}

    
}
