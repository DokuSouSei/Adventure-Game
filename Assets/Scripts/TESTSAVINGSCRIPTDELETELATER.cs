using UnityEngine;
using System.Collections;

public class AIHandler
{
    public string name;
    public int speed; // etc etc just a basic example this does nothing but store 2 vars but its getting pretyt late to show you what i mean
    //i think im going to hit the hay thanks for the help dude
    //Np if you want tomoz after work you can TV me and i can teach you a few things?

}

public class TESTSAVINGSCRIPTDELETELATER : MonoBehaviour {
    float var1 = 1.1f;
    int Char = 1;
    string name = "nuggets";
	// Use this for initialization
	void Start () {
        //Ok so we now saved these vars
        PlayerPrefs.SetFloat("Var1", var1);
        PlayerPrefs.SetInt("SelectedChar", Char);
        PlayerPrefs.SetString("playername", name);

        PlayerPrefs.Save();
        //Loading them again simple ;)
        var1 = PlayerPrefs.GetFloat("Var1");
        Char = PlayerPrefs.GetInt("SelectedChar");
        string playername = PlayerPrefs.GetString("playername");
        //You would do something like that for player char select
        switch(Char)
        {
            case 1:
                GameObject char1 = Instantiate(gameObject, Vector3.zero, Quaternion.identity) as GameObject;
                char1.GetComponent<playerhealth>().curhealth = 10;
                break;//makes me wonder how compact/long your scripts are. i don't know which ones to combine
                //should an enemy, a crate , a key , a door all have the same script? i would make a class that handles everything to do with ai
            case 2:
                GameObject char2 = Instantiate(gameObject, Vector3.zero, Quaternion.identity) as GameObject;
                char2.GetComponent<playerhealth>().curhealth = 50;
                break;
            case 3:
                GameObject char3 = Instantiate(gameObject, Vector3.zero, Quaternion.identity) as GameObject;
                char3.GetComponent<playerhealth>().curhealth = 100;
                break;
        }
       
	
	}

    void OnGUI()
    {
        name = GUI.TextArea(new Rect(10, 10, 100, 20), name);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
