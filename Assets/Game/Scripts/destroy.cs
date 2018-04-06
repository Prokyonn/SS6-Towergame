using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject bullet;

    // Use this for initialization
    void Start()
    {
        Destroy(bullet, 1f);
    }

    // Update is called once per frame
    void Update()
    {
    }
}