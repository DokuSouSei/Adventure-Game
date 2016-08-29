using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class lobbohealth : MonoBehaviour {
    public int curhealth = 100;
    public int maxhealth = 100;
    public Text health;
    public Slider healthBar;
    public GameObject playerobject;
    private playerhealth playerhealth;
    void Start()
    {
        try
        {
            GameObject playerobject = GameObject.FindGameObjectWithTag("player");
            playerhealth = playerobject.GetComponent<playerhealth>();
        }
        catch
        {
            print("lobboscript couldn't find player or playerhealth");
        }
        curhealth = 100;
        maxhealth = 100;
    }
    void setText()
    {
        if (curhealth >= maxhealth)
        {
            curhealth = maxhealth;
        }

        if (curhealth <= 0)
        {
            curhealth = 0;
        }
        health.text = ("hp :" + curhealth + "/ " + maxhealth);
    }
    void setSlider()
    {
        healthBar.value = curhealth;

    }
    void Update()
    {
        setText();
        setSlider();
        if (curhealth <= 0 )
        {
            if (playerhealth != null)
            {
                playerhealth.curgold += 30;
            }
            //particle effect of gold spewing out or whatever
            Destroy(gameObject);
        }
    }
}
