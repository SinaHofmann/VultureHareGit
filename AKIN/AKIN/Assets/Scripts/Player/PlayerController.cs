using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    
    public float jumpheight = 10f;
    private float horizontalInput;
    
    private float verticalInput;
    

    private Animator anim;
  
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
       
        verticalInput = Input.GetAxis("Jump");

        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);
       
        transform.Translate(Vector2.up * verticalInput * Time.deltaTime * jumpheight);

       if(horizontalInput < 0)
       {
        this.GetComponent<SpriteRenderer>().flipX = true;
       }
       
       else
       {
        this.GetComponent<SpriteRenderer>().flipX = false;
       }

       
          
    }

    void Update()
    {
       
    
       if (horizontalInput == 0)
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
           anim.SetBool("isWalking", true);
        }

        if (verticalInput == 0)
        {
            anim.SetBool("isJumping", false);

        }
        else
        {
            anim.SetBool("isJumping", true);
        }

      
        

    }

    
}
