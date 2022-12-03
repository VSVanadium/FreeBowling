using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private Vector3 pos;
    private Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
        rot = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.position = pos;
            gameObject.transform.rotation = rot;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }

    }
}
