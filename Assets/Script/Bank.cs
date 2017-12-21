using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    public float DoubleTapDelay = 0.5f;
    public float BarrellDuration = 1.0f;
    public float BankTime = float.MaxValue;
    private bool BankButtonDown = false;
    private bool InBarrell = false;

    void Update ()
    {
        if(!InBarrell)
        { 
           float BankAxis = Input.GetAxis("Bank");

            //pulling the euler data and asign the z axis to the  value of the player input
            Vector3 NewRotationEuler = transform.rotation.eulerAngles;
            NewRotationEuler.z = -90 * BankAxis;
            //conecting the quaternion with the respective euler atributes
            //IT'S ADVICED NOT TO MESS DIRECTLY WITH QUATERNIONS
            Quaternion NewQuaternion = Quaternion.identity;
            NewQuaternion.eulerAngles = NewRotationEuler;
            //applying the changes in the transform
            transform.rotation = NewQuaternion;
            //if button is not pressed
            if (BankAxis < 0)
            {
                BankButtonDown = false;
            }
            //if button is pressed
            else if(BankButtonDown == false)
            {
                BankButtonDown = true;
                if (BankTime < DoubleTapDelay)
                {
                    StartCoroutine("BarrellRollLeft");
                }
                BankTime = 0.0f;
            }

            BankTime += Time.deltaTime;
        }
		
	}

    IEnumerator BarrellRollLeft()
    {
        InBarrell = true;
        float t = 0.0f;
        Vector3 InitialRoation = transform.localRotation.eulerAngles;
        Vector3 GoalRotation = InitialRoation;
        GoalRotation.z += 180.0f;
        Vector3 CurrentRotation = InitialRoation;

        while (t < BarrellDuration/2.0f)
        {
            CurrentRotation.z = Mathf.Lerp(InitialRoation.z, GoalRotation.z, t/(BarrellDuration / 2.0f));
            transform.rotation = Quaternion.Euler(CurrentRotation);
            t += Time.deltaTime;
            yield return null;
        }
        t = 0;
        InitialRoation = transform.localRotation.eulerAngles;
        GoalRotation = InitialRoation;
        GoalRotation.z += 180.0f;

        while (t < BarrellDuration/2.0f)
        {
            CurrentRotation.z = Mathf.Lerp(InitialRoation.z, GoalRotation.z, t / (BarrellDuration / 2.0f));
            transform.localRotation = Quaternion.Euler(CurrentRotation);
            t += Time.deltaTime;
            yield return null;
        }
        InBarrell = false;
    }
}
