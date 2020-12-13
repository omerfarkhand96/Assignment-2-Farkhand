using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimSound : MonoBehaviour
{

    public AudioSource rFootStep;
    public AudioSource lFootStep;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void PlayerRightFootStepSfx()
    {
        rFootStep.Play();
    }

    private void PlayerLeftFootStepSfx()
    {
        lFootStep.Play();
    }
}
