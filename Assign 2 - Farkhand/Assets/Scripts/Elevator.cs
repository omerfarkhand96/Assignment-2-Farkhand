using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    bool isPlayerIn = false;
    float timer = 5;
    float m_speed = 10;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 endPosition = new Vector3(-1.94f, 14f, 12.16f);

        if (isPlayerIn == true)
        {
            /*timer -= 1 * Time.deltaTime * 1;
            Debug.Log("Timer = " + timer);
            if (timer <= 0f)
            {
            */  Debug.Log("Speed = " + m_speed);

                if (Vector3.Distance(transform.position, endPosition) > 0.01f)
                {
                    this.transform.Translate(0, 2 * Time.deltaTime, 0);
                }
            //}
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isPlayerIn = true;
            Debug.Log("Player In");
        }
        else
        {
            isPlayerIn = false;
        }
    }

}
