using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaMoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    //public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
