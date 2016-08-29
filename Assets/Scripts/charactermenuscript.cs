 using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class charactermenuscript : MonoBehaviour {

    public string characterselected ="Choose your destiny";
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
