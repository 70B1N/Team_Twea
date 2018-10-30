using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WASDscript : MonoBehaviour
{

    public float moveSpeed = 5f;
    //public float turnSpeed = 5f;
    // Use this for initialization
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            Debug.Log("w key pressed");
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -moveSpeed);
            Debug.Log("s key pressed");
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            Debug.Log("a key pressed");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            Debug.Log("d key pressed");

        }
    }
}