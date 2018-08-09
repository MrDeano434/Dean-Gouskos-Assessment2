using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	void Start ()
    {
		
	}
	
	void Update ()
    {


        //Movement();
    }






   /* void Movement()
    {
        if (Input.GetKeyDown(KeyCode.D))
            transform.Translate(1, 0, 0);
    }
    */


}





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
