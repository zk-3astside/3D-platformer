using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float maxSpeed = 3.0f;
    float rotation = 0.0f;

    GameObject cam;



    // Start is called before the first frame update
    float rotationSpeed = 2.0f;
    float camRotationSpeed = 1.5f;

    void Start()
    {
        cam = GameObject.Find("Main Cmaera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (transform.forward * Input.GetAxis("vertical") * maxSpeed);

        rotation = rotation + Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));  
    }
}
