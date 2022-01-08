using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject victoryMessage;
    // Start is called before the first frame update
    void Start()
    {
        victoryMessage.SetActive(false);
    }

   private void OnTriggerEnter(Collider other)
    {
        victoryMessage.SetActive(true);
    }
}
