using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTexture : MonoBehaviour
{
    public Vector2 ScrollSpeed = Vector2.one;
    private Material mat;

	// Use this for initialization
	void Start ()
    {
        mat = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update ()
    {
        mat.mainTextureOffset += ScrollSpeed*Time.deltaTime;
	}
}
