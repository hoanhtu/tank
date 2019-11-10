using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController2 : MonoBehaviour
{
    public Rigidbody2D Rb;
    private float speed=6;
    private float velx;
    private float vely;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velx = Input.GetAxis("Horizontal");
        vely = Rb.velocity.y;
        Rb.velocity = new Vector2(velx*speed,vely);

        if(velx == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
            anim.SetBool("isRunning", true);
    }
}
