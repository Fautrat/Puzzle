using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotateZ = Input.GetAxis("Horizontal") * -1;
        float rotateX = Input.GetAxis("Vertical") ;
        Vector3 rotate = new Vector3(rotateX, 0, rotateZ);
        transform.Rotate(rotate * Time.deltaTime * rotateSpeed );
    }
}
