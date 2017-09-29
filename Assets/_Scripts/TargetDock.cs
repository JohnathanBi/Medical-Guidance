using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetDock : MonoBehaviour {
    DockManager myDockManager;
    Material myMaterial;
    
    //This will be the name displayed on the panel
    public string DockName;


    public Text DockingStatusText;

	// Use this for initialization
	void Start () {
        myDockManager = GetComponent<DockManager>();
        Renderer myRend = GetComponent<Renderer>();
        myMaterial = myRend.material;
	}

    private void Update()
    {

        if (myDockManager.DockSuccessfull)
        {
            myMaterial.color = Color.green;
            DockingStatusText.text = DockName + ": Dock Successfull!";
        }
        else
        {
            myMaterial.color = Color.red;

            //tells user how far the targetdock is to the controller dock, when the two are in contact with each other
            DockingStatusText.text = DockName + ": " + myDockManager.GetDistanceToDock();
        }
    }

    
}
