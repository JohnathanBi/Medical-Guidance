using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DockTimer : MonoBehaviour {
    bool timing = false;
    float startTime;

    public void BeginDockTiming () {
        startTime = Time.time;
        timing = true;
    }


    public float FinishDockTiming() {
        timing = false;
        float TimeToDock = Time.time - startTime;
        startTime = 0;
        return TimeToDock;
    }

    public bool isTiming() {
        return timing;
    }
}
