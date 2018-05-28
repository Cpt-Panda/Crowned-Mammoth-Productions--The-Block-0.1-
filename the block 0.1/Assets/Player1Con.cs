using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Con : MonoBehaviour {

    static Animator anim;
    public float speed = 1.0F;
    public float rotationspeed = 100.0F;

    // (triggers) isJump isRun isLeftRun isRightRun isIdle
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationspeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("isJump");
        }
		
        if(translation != 0)
        {
            anim.SetBool("isRun", true);
            anim.SetBool("isIdle", false);
        }
        else
        {
            anim.SetBool("isRun", false);
            anim.SetBool("isIdle", true);
        }

	}
}
