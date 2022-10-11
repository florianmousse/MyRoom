using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{
    public Collider planet1;
    public Collider planet2;

    public Text testtext;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        testtext.text = "Gravity activated";

        planet1.attachedRigidbody.useGravity = true;
        planet2.attachedRigidbody.useGravity = true;
    }

    void OnTriggerExit(Collider other)
    {
        testtext.text = "WELCOME TO MY ROOM\n\nControls :\n- A to switch position\n- B to quit\n- X to change color";
    }
}
