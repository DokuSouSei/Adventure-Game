using UnityEngine;
using System.Collections;

public class debrimovement : MonoBehaviour {


	void Update () {
        if (Input.GetMouseButton(0))
        {
            Vector3 temp = Input.mousePosition;
            temp.z = 15f; // distance you from camera
            this.transform.position = Camera.main.ScreenToWorldPoint(temp);
        }
    }
}
