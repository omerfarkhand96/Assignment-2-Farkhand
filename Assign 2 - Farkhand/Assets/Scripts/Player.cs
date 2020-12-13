using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class Player : MonoBehaviour
{
    public Animator animator;
    public float currentHealth = 100f;
    public float maxHealth = 100f;
    public HealthBar healthBar;
    public float GetHealth() { return currentHealth; }
    public void SetHealth(float health) { this.currentHealth = health; }
    
    public void TakeDamage(float damage) { currentHealth -= damage; }

    public GameObject rifle;

    public GameObject box;
    
    public GameObject handgun;

    public GameObject player;

    private bool handgunPicked = true;
    private bool riflePicked = false;
    private bool boxPicked = false;
    public bool keyPicked = false;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        handgun.SetActive(false);
        rifle.SetActive(false);
        box.SetActive(false);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            if (riflePicked == true)
            {
                EquipRifle();
            }
        } else if (Input.GetKey(KeyCode.T))
        {
            if (handgunPicked == true)
            {
                EquipGun();
            }
        } else if (Input.GetKey(KeyCode.B))
        {
            if (boxPicked == true)
            {
                EquipBox();
            }
        } else if (Input.GetKey(KeyCode.U))
        {
            UnEquip();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            TakeDamage(10);
            healthBar.SetHealth(currentHealth);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rifle")
        {
            riflePicked = true;
            Debug.Log(riflePicked);
        } else if (other.tag == "Box")
        {
            boxPicked = true;
            Debug.Log(boxPicked);
        } else if (other.tag == "Key")
        {
            keyPicked = true;
        }

        if(other.tag == "Goal")
        {
            SceneManager.LoadScene("End");
        }

    }

    private void EquipRifle()
    {
        if (rifle.activeInHierarchy == false)
        {
            rifle.SetActive(true);
            handgun.SetActive(false);
            player.SetActive(true);
            box.SetActive(false);
            animator.SetBool("RifleEquip", true);
        }
    }

 
    private void EquipGun()
    {
        if (handgun.activeInHierarchy == false)
        {
            rifle.SetActive(false);
            handgun.SetActive(true);
            player.SetActive(true);
            box.SetActive(false);
            animator.SetBool("HandGunEquip", true);
        }
        
    }

    private void EquipBox()
    {
        if(box.activeInHierarchy == false)
        {
            box.SetActive(true);
            player.SetActive(false);
            handgun.SetActive(false);
            rifle.SetActive(false);

        }
    }

    private void UnEquip()
    {
        if (box.activeInHierarchy == true || handgun.activeInHierarchy == true || rifle.activeInHierarchy == true)
        {
            box.SetActive(false);
            player.SetActive(true);
            handgun.SetActive(false);
            rifle.SetActive(false);
            animator.SetBool("HandGunEquip", false);
            animator.SetBool("RifleEquip", false);
        }
    }

}
