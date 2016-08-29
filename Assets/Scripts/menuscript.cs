using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour {

    public void play()
    {
        SceneManager.LoadScene("CharacterSelect");
        print("SceneManager LoadScene");
    }
    public void quit()
    {
        Application.Quit();
        print("Application Quit");
    }
    public void quittomenu()
    {
        SceneManager.LoadScene("Menu");
        print("SceneManager LoadScene menu");
    }
}
