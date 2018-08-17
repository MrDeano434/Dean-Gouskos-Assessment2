using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rotation rot;
    public float speed = 6f;
    public float jumpForce = 7;
    public LayerMask groundLayers;
    public SphereCollider col;

    Vector3 movement;
    Rigidbody playerRigidbody;


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if (rot.direction == Direction.Direction1)
        {
            //float h = Input.GetAxisRaw("Horizontal");
            //float v = Input.GetAxisRaw("Vertical");
            //Move(h, v);
            MoveAll(h, v);
        }
        else if (rot.direction == Direction.Direction2)
        {
            //float h2 = Input.GetAxisRaw("Horizontal");
           // float v2 = Input.GetAxisRaw("Vertical");
            //MoveTwo(h2, v2);
            MoveAll(-v, -h);
        }
        else if (rot.direction == Direction.Direction3)
        {
            //float h3 = Input.GetAxisRaw("Horizontal");
            //float v3 = Input.GetAxisRaw("Vertical");
            //MoveThree(h3, v3);
            MoveAll(-h, -v);
        }
        else if (rot.direction == Direction.Direction4)
        {
            //float h4 = Input.GetAxisRaw("Horizontal");
            //float v4 = Input.GetAxisRaw("Vertical");
            //MoveFour(h4,v4);
            MoveAll(v, h);
        }

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }



    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);

    }

    void MoveAll(float h, float v)
    {
        movement.Set(h, 0f, v);

        movement = movement.normalized * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movement);
    }



    //void Move(float h, float v)
    //{
    //    movement.Set(h, 0f, v);

    //    movement = movement.normalized * speed * Time.deltaTime;
 
    //    playerRigidbody.MovePosition(transform.position + movement);
    //}



    //void MoveTwo(float h2, float v2)
    //{
    //    movement.Set(-v2, 0f, -h2);

    //    movement = movement.normalized * speed * Time.deltaTime;

    //    playerRigidbody.MovePosition(transform.position + movement);
    //}



    //void MoveThree(float h3, float v3)
    //{
    //    movement.Set(-h3, 0f, -v3);

    //    movement = movement.normalized * speed * Time.deltaTime;

    //    playerRigidbody.MovePosition(transform.position + movement);
    //}



    //void MoveFour(float h4, float v4)
    //{
    //    movement.Set(v4, 0f, h4);

    //    movement = movement.normalized * speed * Time.deltaTime;

    //    playerRigidbody.MovePosition(transform.position + movement);
    //}

}















    //void Update()
    //{

    //Movement();
    /* void Movement()
     {
         if (Input.GetKeyDown(KeyCode.D))
             transform.Translate(1, 0, 0);
     }
     */
    //}

    /*void CheckRotation()
    {
        if (rot.direction == Direction.Direction1)
            
    }*/


/*  Need to reference camera direction script (4 directions)
 *  If statements
 * 
 *  If (cameradirection == Direction1) (Direction1 is default facing camera)
 *  Movementleft will be on X-axis left
 *  Movementright will be on X-axis right
 *  
 *  If (cameradirection == Direction2) (Direction2 is 90 degrees to the right from default)
 *  Movementleft will be on Z-axis left
 *  Movementright will be on Z-Axis right
 *
 * If (cameradirection == Direction3) (Direction3 is opposite of default facing camera)
 * Movementleft will be on X-axis right
 * Movementright will be on X-axis left
 * 
 * If (cameradirection == Direction4) (Direction4 is opposite of Direction2)
 * Movementleft will be on Z-axis right
 * Movementright will be on Z-axis left
 * 
 * 
 * Jump will always be along Y-axis up
 */
