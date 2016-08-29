using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {

    private GameObject enemy;
    private lobbohealth lobbohealth;
    private GameObject player;
    private playerhealth playerhealth;

    void Start () {
        try
        {
            enemy = GameObject.FindWithTag("enemy");
            lobbohealth = enemy.GetComponent<lobbohealth>();
        }
        catch { print("couldn't find lobbo"); }
        try
        {
            player = GameObject.FindWithTag("player");
            playerhealth = player.GetComponent<playerhealth>();
        }
        catch { print("couldn't find player"); }
        playerhealth.curmana -= 15;
    }
    void OnTriggerEnter(Collider Col)
    {
        if(Col.tag == "enemy")
        {
            lobbohealth.curhealth -= 5;
            Destroy(gameObject);
        }
    }
}