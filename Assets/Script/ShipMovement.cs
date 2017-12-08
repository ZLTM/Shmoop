using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

    public float MovementSpeed = 1.0f;
    public int invert = -1; //1 for standar -1 for invert
    public float Aim = 200.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(Horizontal, invert * Vertical, 0);
        Vector3 FinalDirection = new Vector3(Horizontal, invert * Vertical, 1.0f);

        transform.position += direction*MovementSpeed*Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(FinalDirection),Mathf.Deg2Rad*Aim);
	}
}
