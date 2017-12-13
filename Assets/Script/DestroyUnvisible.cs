using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyUnvisible : MonoBehaviour
{
    void OnBecameInvisible()//for some reason using scene view is considered visible so test this using maximise on play
    {
        Destroy(gameObject);
    }

}
