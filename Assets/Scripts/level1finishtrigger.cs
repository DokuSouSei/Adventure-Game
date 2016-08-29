using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class level1finishtrigger : MonoBehaviour {

    private Transform Camera;
    private Vector3 cameragoto;
    void Start()
    {
        cameragoto = new Vector3(0,1,-10);
        Camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    void OnTriggerEnter()
    {
        Camera.position = cameragoto;
        //put popup menu here saying you finished "continue" "quit" or something
            //loadstats over to controller
                //destroy player
            SceneManager.LoadScene("WorldSelect");
        }
}
