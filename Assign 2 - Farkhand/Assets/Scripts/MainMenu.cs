using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource gunShot;
    public AudioSource bg;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        Debug.Log("Button Hit");
        gunShot.Play();
        bg.Stop();
        StartCoroutine(LoadGame());
        
    }

    public void Menu()
    {
        Debug.Log("Back to Main Menu");
        gunShot.Play();
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Debug.Log("Quit Button Hit");
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    IEnumerator LoadGame()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Game");
    }
}
