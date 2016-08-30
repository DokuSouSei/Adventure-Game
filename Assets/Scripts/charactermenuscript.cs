 using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class charactermenuscript : MonoBehaviour {

    //this string is just to show which character the player has selected currently
    public string characterselected ="Choose your destiny";

    //this Text is where the current player choice should be kept so later when we spawn the player the gamecontroller knows which to spawn
    public Text currentchoice;

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    void Update()
    {
        currentchoice.text = characterselected;
    }
    public void play()
    {
        //play button function
        //supposed to force the player to choose a character first before playing
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
        //back button function
        //loads main menu
        SceneManager.LoadScene("Menu");
        currentchoice.text = "Choose your destiny";
    }
    //character choosing button functions
    //functions to change current character selection to whichever pressed
    public void rogueselect()
    {
        characterselected = "rogue";
    }
    public void warriorselect()
    {
        characterselected = "warrior";
    }
    public void wizardselect()
    {
        characterselected = "wizard";
    }
}
