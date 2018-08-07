using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

    public Transform player;
    public GameObject playerObject;
    private float initialForwardForce;

    private void Start()
    {
        initialForwardForce = playerObject.GetComponent<PlayerMovement>().forwardForce;
    }
    

    // Update is called once per frame
    void FixedUpdate () {
        
	}
}
