using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiController : MonoBehaviour
{
    // Predefined RGB Colours
    Color c_Highlight = new Color(0.9f, 0.84f, 0.62f);
    Color c_Default = new Color(0.66f, 0.66f, 0.66f);

    // Selected Character
    int selectChar = 0;

    Vector3 menuPos_Main = new Vector3(381, -85, 0);
    Vector3 menuPos_CS = new Vector3(-695, -85, 0);

    // Set up SFX stuff
    public AudioClip menuSelect;
    public AudioClip menuSwitch;
    AudioSource audio;

    // Menu Objects
    public GameObject menuMain;
    public GameObject menuCS;

    // Text Objects
    public Text txtRogue;
    public Text txtWarrior;
    public Text txtWizard;
    public Text txtPlay;
    public Text txtBack;
    public Text txtCSTitle;
    public Text txtNewGame;
    public Text txtQuit;


    void Start()
    {
        audio = GetComponent<AudioSource>();

    }

    // onClick functions
    public void OnClick(string option)
    {
        switch (option.ToLower())
        {
            case "new game":
                menuMain.SetActive(false);
                menuCS.SetActive(true);
                audio.PlayOneShot(menuSwitch, 1.0f);
                break;
            case "back":
                menuMain.SetActive(true);
                menuCS.SetActive(false);
                audio.PlayOneShot(menuSwitch, 1.0f);
                break;
            case "play":
                if (selectChar >= 1 && selectChar <= 3)
                {
                    txtCSTitle.text = "Choose a character first";
                }
                else
                {
                    SceneManager.LoadScene("WorldSelect");
                }
                break;
            case "rogue":
                txtCSTitle.text = "Rogue";
                break;
            case "warrior":
                txtCSTitle.text = "Warrior";
                break;
            case "wizard":
                txtCSTitle.text = "Wizard";
                break;
            case "quit":
                Application.Quit();
                break;

        }
    }

    // When the mouse hovers over a button
    public void OnMouseOver(string Button)
    {
        switch (Button.ToLower())
        {
            case "rogue":
                txtRogue.color = c_Highlight;
                audio.PlayOneShot(menuSelect,0.5f);
                break;
            case "warrior":
                txtWarrior.color = c_Highlight;
                audio.PlayOneShot(menuSelect,0.5f);
                break;
            case "wizard":
                txtWizard.color = c_Highlight;
                audio.PlayOneShot(menuSelect,0.5f);
                break;
            case "play":
                txtPlay.color = c_Highlight;
                audio.PlayOneShot(menuSelect, 0.5f);
                break;
            case "back":
                txtBack.color = c_Highlight;
                audio.PlayOneShot(menuSelect, 0.5f);
                break;
            case "new game":
                txtNewGame.color = c_Highlight;
                audio.PlayOneShot(menuSelect, 0.5f);
                break;
            case "quit":
                txtQuit.color = c_Highlight;
                audio.PlayOneShot(menuSelect, 0.5f);
                break;
            default:
                break;
        }

    }

    // When the mouse stops hovering over a button
    public void OnMouseOff(string Button)
    {
        switch (Button.ToLower())
        {
            case "rogue":
                txtRogue.color = c_Default;
                break;
            case "warrior":
                txtWarrior.color = c_Default;
                break;
            case "wizard":
                txtWizard.color = c_Default;
                break;
            case "play":
                txtPlay.color = c_Default;
                break;
            case "back":
                txtBack.color = c_Default;
                break;
            case "new game":
                txtNewGame.color = c_Default;
                break;
            case "quit":
                txtQuit.color = c_Default;
                break;
            default:
                break;
        }

    }
}
