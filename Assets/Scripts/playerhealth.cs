using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerhealth : MonoBehaviour {
    public int curhealth = 100;
    public int maxhealth = 100;
    public int curmana = 100;
    public int maxmana = 100;
    public int curhealthpotions = 0;
    public int curmanapotions = 0;
    public int maxhealthpotions = 3;
    public int maxmanapotions = 3;
    public int curgold = 0;
    public Text health;
    public Text mana;
    public Text healthpotionamount;
    public Text manapotionamount;
    public Text gold;
    public Slider healthBar;
    public Slider manaBar;

    void setText()
    {
        //limit cur* to max* upwards
        if (curhealth > maxhealth){curhealth = maxhealth;}
        if (curmana > maxmana){curmana = maxmana;}
        if (curhealthpotions > maxhealthpotions) { curhealthpotions = maxhealthpotions; }
        if (curmanapotions > maxmanapotions) { curmanapotions = maxmanapotions; }

        //limit cur* to 0 downwards
        if (curhealth < 0){curhealth = 0;}
        if (curmana < 0){curmana = 0;}
        if (curhealthpotions < 0) { curhealthpotions = 0; }
        if (curmanapotions < 0) { curmanapotions = 0; }

        health.text = ("hp :" + curhealth + "/ " + maxhealth);
        mana.text = ("mana :" + curmana + "/ " + maxmana);
        healthpotionamount.text = ("" + curhealthpotions + "/ " + maxhealthpotions);
        manapotionamount.text = ("" + curmanapotions + "/ " + maxmanapotions);
        gold.text = ("gold: " + curgold);
    }
    void setSlider()
    {
        healthBar.value = curhealth;
        manaBar.value = curmana;
    }
    void Update () {
        setText();
        setSlider();
        if (curhealth <= 0 )
        {
            SceneManager.LoadScene("GameOver");
        }
        if (Input.GetButtonDown("HealHealth"))
        {
            curhealthpotions -= 1;
            curhealth = maxhealth;
            print("health refilled");
        }
        if (Input.GetButtonDown("HealMana"))
        {
            curmanapotions -= 1;
            curmana = maxmana;
            print("mana refilled");
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "healthpotion") { curhealthpotions += 1; }
        if (col.tag == "manapotion") { curmanapotions += 1; }
        if (col.tag == "enemy") { curhealth -= 30; }
    }
}
