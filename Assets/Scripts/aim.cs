using UnityEngine;
using System.Collections;

public class aim : MonoBehaviour {

    //This class points the wand at the cursor

        //cursor obvi
    public Transform cursortarget;

	void Update () {
        //lookat cursor
        transform.LookAt(cursortarget);
    }
}