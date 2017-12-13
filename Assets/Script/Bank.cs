using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{	
	void Update ()
    {//we pull the euler data and asign the z axis to the  value of the player input
        Vector3 NewRotationEuler = transform.rotation.eulerAngles;
        NewRotationEuler.z = -90 * Input.GetAxis("Bank");
        //we connect the quaternion with the respective euler atributes
        //IT'S ADVICED TO NOT MESS DIRECTLY WITH QUATERNIONS
        Quaternion NewQuaternion = Quaternion.identity;
        NewQuaternion.eulerAngles = NewRotationEuler;
        //we appli the changes in the transform
        transform.rotation = NewQuaternion;
		
	}
}
