using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class introvideo : MonoBehaviour
{

    MovieTexture mt;
    RectTransform rt;
    Vector2 origPos;

    void Awake()
    {
        rt = GetComponent<RectTransform>();
        origPos = rt.anchoredPosition;


        RawImage rim = GetComponent<RawImage>();
        mt = (MovieTexture)rim.mainTexture;
        mt.Play();
    }

    void Update()
    {
        if(!mt.isPlaying)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}