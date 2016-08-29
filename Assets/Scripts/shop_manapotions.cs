using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class shop_manapotions : MonoBehaviour
{
    private GameObject manashopcanvas;
    private Text manashoptext;
    private bool opened;
    private new AudioSource audio;
    private AudioClip voice1;
    private AudioClip voice2;
    private AudioClip voice3;
    private playerhealth playerhealthscript;
    void Start()
    {
        try
        {
            GameObject player = GameObject.FindGameObjectWithTag("player");
            playerhealthscript = player.GetComponent<playerhealth>();
        }
        catch { print("couldn't find player"); }
        voice1 = Resources.Load("Sounds/SFX/NPC_Voice_01") as AudioClip;
        voice2 = Resources.Load("Sounds/SFX/NPC_Voice_02") as AudioClip;
        voice3 = Resources.Load("Sounds/SFX/NPC_Voice_03") as AudioClip;
        audio = GetComponent<AudioSource>();
        manashopcanvas = GameObject.FindGameObjectWithTag("shop_manapotion_canvas");
        manashoptext = GameObject.FindGameObjectWithTag("shop_manapotion_canvas_text").GetComponent<Text>();
        manashoptext.text = "haggord: press 'e' to buy mana potion";
        manashopcanvas.SetActive(false);
    }
    void OnTriggerEnter()
    {
        opened = true;
        audio.PlayOneShot(voice1);
    }
    void Update()
    {

        if (opened)
        {
            manashopcanvas.SetActive(opened);
            if (Input.GetKeyDown("e"))
            {

                if (playerhealthscript.curgold >= 20 && playerhealthscript.curmanapotions < 3)
                {
                    audio.PlayOneShot(voice2);
                    manashoptext.text = "haggord: Horray!";
                    playerhealthscript.curgold -= 20;
                    playerhealthscript.curmanapotions += 1;

                }
                else if (playerhealthscript.curgold < 20)
                {
                    manashoptext.text = "haggord: not enough monay!";
                }
                else if (playerhealthscript.curmanapotions >= 3)
                {
                    manashoptext.text = "haggord: you can't hold anymore!";
                }
            }
        }
    }
    void OnTriggerExit()
    {

        audio.PlayOneShot(voice3);
        manashoptext.text = "haggord: come back anytime!";
        opened = false;
    }
}
