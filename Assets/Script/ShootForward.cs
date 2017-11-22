using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootForward : MonoBehaviour {

    public Rigidbody Bullet;
    public float Velocity = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody NewBullet = Instantiate(Bullet, transform.position, transform.rotation) as Rigidbody;
            NewBullet.AddForce(transform.forward * Velocity, ForceMode.VelocityChange);
        }
	}
}
