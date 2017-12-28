using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public float movespeed = 3.0f;
    public float rotatespeed = 20.0f;
	// Update is called once per frame
	void Update () {
        float deltaX = Input.GetAxis("Horizontal") * rotatespeed;
        float deltaZ = Input.GetAxis("Vertical") * movespeed;
        transform.Translate(0,0,deltaZ * Time.deltaTime);
        transform.Rotate(0,deltaX * Time.deltaTime,0);
	}
}
