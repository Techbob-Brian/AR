using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boyAnim : MonoBehaviour
{
    public Animator anim;
    public AudioSource audio;

    // Start is called before the first frame update
     void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Waving", -1, 0f);
        anim.speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void wave()
    {
        anim.Play("Waving", -1, 0f);
        anim.speed = 1f;
        audio.Stop();
    }

    public void sing()
    {
        anim.Play("Singing", -1, 0f);
        anim.speed = 1f;
        audio.Play();
    }

    public void pose()
    {
        anim.Play("Male Standing Pose", -1, 0f);
        anim.speed = 1f;
        audio.Stop();
    }
}