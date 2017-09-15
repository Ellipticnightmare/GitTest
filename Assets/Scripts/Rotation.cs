using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 5f;

    // Use this for initialization

	// Update is called once per frame
	void Update ()
    {
        float inputH = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3 (0, inputH * rotationSpeed, 0));
	}
}
