using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float Maxhealthpoints = 100;
    public float Currenthealthpoints;
    public float Healthregen;
    public bool Control = true;

	
	void Start ()
    {
        Currenthealthpoints = 100;
	}
	
	
	void Update ()
    {
        if (Currenthealthpoints <= 0)
        {
            Healthregen = 0;
            Control = false;
        }
           
    }
}
