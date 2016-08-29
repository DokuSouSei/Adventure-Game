using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WorldSelectCamera : MonoBehaviour {
    RaycastHit hit;
    Ray ray;
    private string hitobj;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            hitobj = hit.collider.gameObject.name;
            if (Input.GetMouseButtonDown(0))
            {
                //if mouse0 pressed check if tag is a valid level
                if (hitobj == "Level1" || hitobj == "Level2"|| hitobj == "Level3" || hitobj == "town")
                {
                    //load the valid level name clicked on
                    if (SceneManager.GetActiveScene().name == "WorldSelect")
                    {
                        Debug.Log(hitobj);
                        SceneManager.LoadScene(hitobj);
                    }
                }
            }
        }
    }
}
