using UnityEngine;
using System.Collections;
using System;

public class wizardweapon : MonoBehaviour {
    public Transform target;
    public RaycastHit hit;

    private lobbohealth enemyhealthscript;
    public Animator animator;
    private GameObject wizard;
    private bool grabbed = false;
    private bool shooting = false;
    public GameObject spellbeam;
    public GameObject prefab;
    public GameObject wandend;

    //private GameObject player;
    private playerhealth playerhealth;
    private string leftclickspell = "ProjectileSpell";
    private string rightclickspell = "ProjectileSpell";

    //Start runs as soon as this script is seen by unity. So anything in here should run as soon as the player renderes but it will only run once
    //yeah i would have stuck with start and update normally too. when i tried to implement the gamecontroller and persistancy of the player character i started using onlevelload. 
    //Iv never found a good use for OnLevelLoad for any of my projects. the only time iv used it is when i was learning it
    void Start () {
        
        playerhealth = gameObject.GetComponent<playerhealth>();
        GameObject enemy = GameObject.FindGameObjectWithTag("enemy");
        enemyhealthscript = enemy.GetComponent<lobbohealth>();
        print("found lobbo");
    }

    //This is kinda stupid because your player loads after the level so anything in here is either ganna work some times or not at all
    void OnLevelLoad()
    {
        //prefab = (GameObject)Resources.Load("projectile");

        wizard = GameObject.FindGameObjectWithTag("wizard");
        animator = wizard.GetComponent<Animator>();
        try
        {
           
        }
        catch
        {
            print("no lobbos around, try putting one in the scene");
        }
        try
        {
            //player = GameObject.FindWithTag("player");
            //playerhealth = player.GetComponent<playerhealth>();
        }
        catch { print("couldn't find player"); }
    }
	void Update () {


        if (Input.GetMouseButtonDown(0))
        {
            shooting = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            shooting = false;
            spellbeam.SetActive(false);
        }
        if (shooting == true)
        {
            spellbeam.SetActive(true);
            if (Physics.Linecast(transform.position, target.position, out hit))
            {
                string tagofhit = hit.collider.gameObject.tag;
                if (tagofhit == "enemy")
                {
                    playerhealth.curmana -= 1;
                    enemyhealthscript.curhealth -= 1;
                    Debug.Log(gameObject.tag + "hit " + tagofhit + " with LMB weapon");
                }
            }
        }
            //move things around with middle mouse click.
            if (Input.GetMouseButtonDown(2))
            {
                grabbed = true;
            }
            if (Input.GetMouseButtonUp(2))
            {
                grabbed = false;
            }
            if (grabbed == true)
            {
                if (Physics.Linecast(transform.position, target.position, out hit))
                {
                    string tagofhit = hit.collider.gameObject.tag;
                    Debug.Log(gameObject.tag + " Hit:  " + tagofhit);
                    if (tagofhit == "crate" || tagofhit == "Key")
                    {
                        Debug.Log(gameObject.tag + "hit " + tagofhit + " with MMB weapon");
                        Vector3 temp = Input.mousePosition;
                        temp.z = 15f; // Set this to be the distance you want the object to be placed in front of the camera.

                        hit.transform.position = Camera.main.ScreenToWorldPoint(temp);
                    }
                }
            }
        //right mouse click
        if (Input.GetMouseButtonDown(1))
        {
            if (playerhealth.curmana > 1)
            {
                GameObject projectile = Instantiate(prefab) as GameObject;
                projectile.transform.position = wandend.transform.position;
                Rigidbody rb2 = projectile.GetComponent<Rigidbody>();
                rb2.velocity = wandend.transform.forward * 20;
            }
        }
    }
}