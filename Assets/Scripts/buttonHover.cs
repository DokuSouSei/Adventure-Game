using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonHover : MonoBehaviour
{
    // Predefined RGB Colours
    Color c_Highlight = new Color(0.9f, 0.84f, 0.62f);
    Color c_Default = new Color(0.66f, 0.66f, 0.66f);

    // Set up SFX stuff
    public AudioClip menuSelect;
    AudioSource audio;

    // Text Objects
    public Text txtRogue;
    public Text txtWarrior;
    public Text txtWizard;
    public Text txtPlay;
    public Text txtBack;

    void Start()
    {
        audio = GetComponent<AudioSource>();
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
            default:
                break;
        }

    }
}
