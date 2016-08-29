using UnityEngine;
using System.Collections;

public class aim : MonoBehaviour {
    public Transform cursortarget;
	void Update () {
        transform.LookAt(cursortarget);
    }
}
