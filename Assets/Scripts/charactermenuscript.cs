using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class charactermenuscript : MonoBehaviour {

    public string characterselected ="Choose your destiny";
    public Text currentchoice;

    private GameObject gamecontroller;
    private GameController GameController;

    void Start()
    {
        try
        {
            GameObject gamecontroller = GameObject.FindGameObjectWithTag("GameController");
            GameController = gamecontroller.GetComponent<GameController>();
        }
        catch
        {
            print("charmenu couldn't find GameController");
        }
        DontDestroyOnLoad(transform.gameObject);
    }
    void Update()
    {
        //currentchoice.text = characterselected;
    }
    public void play()
    {
        if(characterselected == "Choose your destiny")
        {
            currentchoice.text = "Choose a character first";
        }
        else
        {
            SceneManager.LoadScene("WorldSelect");
        }
    }
    public void back()
    {
        SceneManager.LoadScene("Menu");
        currentchoice.text = "Choose your destiny";
    }
    //set current choice in gamecontroller
    public void rogueselect()
    {
        characterselected = "rogue";
        GameController.characterchoice = "rogue";
    }
    public void warriorselect()
    {
        characterselected = "warrior";
        GameController.characterchoice = "warrior";
    }
    public void wizardselect()
    {
        characterselected = "wizard";
        GameController.characterchoice = "wizard";
    }
}
