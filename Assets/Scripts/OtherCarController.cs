using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherCarController : MonoBehaviour
{
    // Private Variables
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
