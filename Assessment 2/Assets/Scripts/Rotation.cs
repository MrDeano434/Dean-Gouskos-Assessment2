using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Direction1, Direction2, Direction3, Direction4
}

public class Rotation : MonoBehaviour {

    public Direction direction;

	
	void Start ()
    {
        direction = Direction.Direction1;
	}
	
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            RotateCamera();
        if (Input.GetKeyDown(KeyCode.E))
            RotateCameraRight();


	}

    void RotateCamera ()
    {
        if (direction == Direction.Direction1)
            direction = Direction.Direction2;
        else if (direction == Direction.Direction2)
            direction = Direction.Direction3;
        else if (direction == Direction.Direction3)
            direction = Direction.Direction4;
        else if (direction == Direction.Direction4)
            direction = Direction.Direction1;

        transform.Rotate(0, 90, 0);
    }

    void RotateCameraRight ()
    {
        if (direction == Direction.Direction1)
            direction = Direction.Direction4;
        else if (direction == Direction.Direction4)
            direction = Direction.Direction3;
        else if (direction == Direction.Direction3)
            direction = Direction.Direction2;
        else if (direction == Direction.Direction2)
            direction = Direction.Direction1;

        transform.Rotate(0, -90, 0);

    }
}



/*Need to do rotation that rotates (player, camera and the cameralock)
 * 0 rotation = Direction1
 * 90 rotation = Direction2
 * 180 rotation = Direction3
 * 270 rotation = Direction4
 * 
 * To rotate right Input.Keycode.E
 * To rotate left Input.Keycode.Q
 */








/*if (direction == Direction.Direction1)
        transform.Rotate(0, 0, 0);
    if (direction == Direction.Direction2)
        transform.Rotate(0, 90, 0);
    if (direction == Direction.Direction3)
        transform.Rotate(0, 180, 0);
    if (direction == Direction.Direction4)
        transform.Rotate(0, 270, 0);
        */
