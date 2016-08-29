using UnityEngine;
using System.Collections;

public class lobbomove : MonoBehaviour {

    public int moveSpeed = 3;
	void Start () {
	
	}
	

	void Update () {
        if (true) { transform.position += Vector3.left * Time.deltaTime; }
	}
}
