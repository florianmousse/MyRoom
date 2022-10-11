using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLight : MonoBehaviour
{
    public Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        // X button
        if (OVRInput.GetDown(OVRInput.Button.Three)) {
            light.color = Color.green;
        }
    }
}