using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloemen : MonoBehaviour
{
    public GameObject Bloem;
    public GameManager gm;


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            gm.remainingShots = gm.remainingShots + 1;
            Debug.Log("raakt bloem");
            Destroy(Bloem);

        }
    }

}
