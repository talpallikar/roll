using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset; 

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //LateUpdate runs every frame after all items are processed in update
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
