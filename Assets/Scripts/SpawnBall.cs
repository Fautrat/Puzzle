using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ballPreFabs;
    // Start is called before the first frame update
    void Start()
    {
        GameObject ball = Instantiate(ballPreFabs);
        float posX = transform.position.x;
        float posZ = transform.position.z;
        float posY = transform.position.y + 1.5f;

        ball.transform.position = new Vector3(posX, posY, posZ);
    }
}
