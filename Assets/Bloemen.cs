using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LelieBloem : MonoBehaviour
{
    public GameObject Bloem;


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {

            Debug.Log("raakt bloem");

        }
    }

}
