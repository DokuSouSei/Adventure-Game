using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FollowingCamera : MonoBehaviour {

    private Transform target;
    public Transform thiscamera;
    void Start () {
	
	}


    void Update()
    {

        if(target != null) {
        thiscamera.position = target.position + new Vector3(0, 0, -10);
        }
        //if in a player interactable level, set camera target to player.
        if (SceneManager.GetActiveScene().name == "Level1" || SceneManager.GetActiveScene().name == "Level2") { target = GameObject.FindGameObjectWithTag("player").transform; }
        //else { target = null; }
    }
}
