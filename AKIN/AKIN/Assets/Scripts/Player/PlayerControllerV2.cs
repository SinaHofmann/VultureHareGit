using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerV2 : MonoBehaviour
{
  private Rigidbody2D rb;
  public float speed;
  public float jumpForce;
  private float moveInput;

  private bool isGrounded;
  public Transform feetPos;
  public float checkRadius;
  public LayerMask whatIsGround;

  private float jumpTimeCounter;
  public float jumpTime;
  private bool isJumping;

  private Animator anim;


  void Start()
  {
      anim = GetComponent<Animator>();
      rb = GetComponent<Rigidbody2D>();
  }

  void FixedUpdate()
  {
      moveInput = Input.GetAxis("Horizontal");
      rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
  }

  void Update()
  {
      isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

     
      if(isGrounded == true && Input.GetKeyDown(KeyCode.Space))
      {
          isJumping = true;
          jumpTimeCounter = jumpTime;
          rb.velocity = Vector2.up * jumpForce;
      } 
      

      if(Input.GetKeyDown(KeyCode.Space) && isJumping == true)
      {
          if(jumpTimeCounter > 0)
          {
              rb.velocity = Vector2.up * jumpForce;
              jumpTimeCounter -= Time.deltaTime;
          }
          else
          {
             isJumping = false;
          }
      }

      if(Input.GetKeyUp(KeyCode.Space))
      {
          isJumping = false;
      }
      
      
      // flip character when moving 
      if(moveInput > 0)
      {
          transform.eulerAngles = new Vector3(0, 0, 0);
      }
      else if(moveInput < 0)
      {
          transform.eulerAngles = new Vector3(0, 180, 0);
      }
      


     // animation
      if(moveInput == 0)
      {
          anim.SetBool("isWalking", false);
      }
      else
      {
          anim.SetBool("isWalking", true);
      }

      if(Input.GetKeyDown(KeyCode.Space))
      {
          anim.SetBool("isJumping", true);
      }
      else{
          anim.SetBool("isJumping", false);
      }




      
  }
}
