using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLossState : MonoBehaviour
{
    public Player player;
    public AudioSource deathSound;
    public float timer = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.currentHealth <= 0)
        {
            deathSound.Play();

            SceneManager.LoadScene("MainMenu");          
               
        }
    }


}
