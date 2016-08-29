using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class shop_healthpotions : MonoBehaviour {
    private GameObject healthshopcanvas;
    private Text healthshoptext;
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
        catch
        {
            print("can't find player");
        }
        voice1 = Resources.Load("Sounds/SFX/NPC_Voice_01") as AudioClip;
        voice2 = Resources.Load("Sounds/SFX/NPC_Voice_02") as AudioClip;
        voice3 = Resources.Load("Sounds/SFX/NPC_Voice_03") as AudioClip;
        audio = GetComponent<AudioSource>();

        try{healthshopcanvas = GameObject.FindGameObjectWithTag("shop_healthpotion_canvas");}
        catch {print("coudn't find health shop canvas");}
        try{healthshoptext = GameObject.FindGameObjectWithTag("shop_healthpotion_canvas_text").GetComponent<Text>();}
        catch {print("couldnt find health shop text"); }
        healthshoptext.text = "haggord: press 'e' to buy health potion";
        healthshopcanvas.SetActive(false);
    }
    void OnTriggerEnter(Collider shopcol)
    {
        print(shopcol.tag);
        opened = true;
        audio.PlayOneShot(voice1);
    }
    void Update()
    {

        if (opened) {
            healthshopcanvas.SetActive(opened);
            if (Input.GetKeyDown("e"))
            {

                if (playerhealthscript.curgold >= 20 && playerhealthscript.curhealthpotions < 3) {
                    //audio.PlayOneShot(voice2);
                    print("voice2 played");
                    healthshoptext.text = "haggord: Horray!";
                    playerhealthscript.curgold -= 20;
                    playerhealthscript.curhealthpotions += 1;
                
                }
                else if(playerhealthscript.curgold < 20)
                {
                    healthshoptext.text = "haggord: not enough monay!";
                }
                else if (playerhealthscript.curhealthpotions >= 3)
                {
                    healthshoptext.text = "haggord: you can't hold anymore!";
                }
            }
        }
    }
    void OnTriggerExit()
    {

        audio.PlayOneShot(voice3);
        healthshoptext.text = "haggord: come back anytime!";
        opened = false;
    }
}
