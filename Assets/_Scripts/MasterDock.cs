using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterDock : MonoBehaviour {

    public DockManager[] DockManagerList;
    Material myMaterial;

    //This will be the name displayed on the panel
    public string DockName;
    public Text DockingStatusText;

    // Use this for initialization
    void Start()
    {
        Renderer myRend = GetComponent<Renderer>();
        myMaterial = myRend.material;
    }

    private void Update()
    {
        int successfullDocks = 0;

        foreach (DockManager dm in DockManagerList) {
            if (dm.DockSuccessfull == true) {
                successfullDocks++;
            }
        }

        if (successfullDocks==DockManagerList.Length)
        {
            myMaterial.color = Color.green;
            DockingStatusText.text = DockName + ": Dock Successfull!";
        }
        else
        {
            myMaterial.color = Color.red;
            DockingStatusText.text = DockName + ": Not Docked";
        }
    }
}
