using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    void OnTriggerEnter(Collider other )
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
