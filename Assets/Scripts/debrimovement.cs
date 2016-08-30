using UnityEngine;
using System.Collections;

public class debrimovement : MonoBehaviour {
    
    //just set this to the same as the camera for it to be on the same
    public int ObjectDistance;

	void Update () {
        //for moving objects around like crates or whatever

        if (Input.GetMouseButton(0))
        {
            Vector3 temp = Input.mousePosition;
            temp.z = 15f; // distance you from camera
            this.transform.position = Camera.main.ScreenToWorldPoint(temp);
        }
    }
}
