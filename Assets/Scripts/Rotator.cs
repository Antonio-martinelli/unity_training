using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float frequency = 6.0f;  // Speed of sine movement
    public float magnitude = 0.4f;   // Size of sine movement
    public int rotationAngle = 130;
    private Vector3 axis;
    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
        axis = transform.forward;  // May or may not be the axis you want

    }

    // Update is called once per frame
    void Update () {

        transform.Rotate(new Vector3(0, 0, rotationAngle) * Time.deltaTime);
        transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}
