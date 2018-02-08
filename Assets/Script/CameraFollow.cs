using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ObjectFollow;
    public Vector3 MovementRatio = Vector3.one;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        Vector3 NewPosition = ObjectFollow.position;

        NewPosition.x *= MovementRatio.x;
        NewPosition.y *= MovementRatio.y;
        NewPosition.z = transform.position.z;
        transform.position = NewPosition;
    }
}
