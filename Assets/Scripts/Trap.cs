using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject start;
    private void OnTriggerEnter(Collider other)
    {
        float posX = start.transform.position.x;
        float posZ = start.transform.position.z;
        float posY = 3;

        other.transform.position = new Vector3(posX, posY, posZ);
    }
}
