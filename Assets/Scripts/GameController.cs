using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    //GameController script
    //spawns player and saves player stats

    public Vector3 playerspawnpoint;
    private bool isSpawned = false;
    GameObject Playerprefab;
    public int curgold = 0;
    public Text gold;
    //need actual characters before we can spawn them
    //GameObject RogueCharacter;
    //GameObject WarriorCharacter;
    //GameObject WizardCharacter;
    public string characterchoice;
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    void Start()
    {
        //load generic testing player character
        try { Playerprefab = Resources.Load("player") as GameObject; }
        catch { print("couldn't load player resource"); }
        //load real characters
        //RogueCharacter = Resources.Load("rogue") as GameObject;
        //WarriorCharacter = Resources.Load("warrior") as GameObject;
        //WizardCharacter = Resources.Load("wizard") as GameObject;
    }
    void OnLevelWasLoaded()
    {
        isSpawned = false;
        //make sure player is loaded
        try { Playerprefab = Resources.Load("player") as GameObject; }
        catch { print("couldn't load player resource"); }
        //testing something
        print("level was loaded");
        print("isspawned ="+isSpawned);
    }
	void Update () {
        if(isSpawned == false)
        {
            if (SceneManager.GetActiveScene().name == "Level1" || SceneManager.GetActiveScene().name == "Level2" || SceneManager.GetActiveScene().name == "LevelTown")
            {
                isSpawned = true;
                Instantiate(Playerprefab);
                Playerprefab.transform.position = playerspawnpoint;
            }
        }
    }
}
