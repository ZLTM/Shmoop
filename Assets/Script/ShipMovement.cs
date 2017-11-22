using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

    public float MovementSpeed = 1.0f;
    public int invert = -1; //1 for standar -1 for invert

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += (new Vector3(Input.GetAxis("Horizontal"), invert *Input.GetAxis("Vertical"), 0))*MovementSpeed*Time.deltaTime;
	}
}
