using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DockManager: MonoBehaviour
{

    public float TranslationalFreedom;
    public bool DockSuccessfull { get; set; }
    
    //if -1 it means that no contact has been made.
    private float DistanceToDock = -1;


    public DockManager()
    {
        DockSuccessfull = false;
    }

    
    
    public void OnTriggerStay(Collider collider)
    {

        if (collider.tag == "ControllerDock")
        {
            if (DockWithinBounds(collider.transform))
            {
                DockSuccessfull = true;
            }
            else
            {
                DockSuccessfull = false;
                DistanceToDock = Vector3.Distance(collider.transform.position, this.transform.position) - TranslationalFreedom;
            }
        }

    }

    public void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "ControllerDock")
        {
            DockSuccessfull = false;
            
            //No longer in contact
            DistanceToDock = -1;
        }
    }

    private bool DockWithinBounds(Transform t) {

        return DockWithinTranslationalBounds(t);
    }


    private bool DockWithinTranslationalBounds(Transform t)
    {
        return Vector3.Distance(t.position, this.transform.position) < TranslationalFreedom;
    }


    public string GetDistanceToDock() {
        return DistanceToDock == -1 ? "No Contact Made" : DistanceToDock + "";
    }

}


