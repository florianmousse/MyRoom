using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchView : MonoBehaviour
{
    public GameObject player;

    public int boolswitch;
    // Start is called before the first frame update
    void Start()
    {
        boolswitch = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One)) {
            if (boolswitch == 0) {
                player.transform.position = new Vector3(20, 4, 24);
                boolswitch = 1;
            } else {
                player.transform.position = new Vector3(0, 2, 0);
                boolswitch = 0;
            }
        }
    }
}
