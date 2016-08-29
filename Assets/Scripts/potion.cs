using UnityEngine;
using System.Collections;

public class potion : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "player")
        {
            //spawn potion particle effect or whatever then destroy
            Destroy(gameObject);
        }
    }
}