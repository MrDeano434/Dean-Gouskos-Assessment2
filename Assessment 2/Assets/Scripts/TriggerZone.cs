using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour {

    public Camera topCamera;
    public Camera mainCamera;

	// Use this for initialization
	void Start () {
        mainCamera.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        //mainCamera.gameObject.SetActive(false);
        topCamera.gameObject.SetActive(true);

        
    }
}
