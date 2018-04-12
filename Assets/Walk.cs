using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {


    public float delta = 0.2f;  // Amount to move left and right from the start point
    public float speed = 0.01f;
    private Vector3 startPos;
    // Use this for initialization
    void Start () {
        startPos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 v = startPos;
        v.y += delta * Time.time * speed;
        transform.position = v;
    }
}
