using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public Vector3 StartPosition;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = StartPosition;
    }

    private void OnTriggerEnter(Collider collision)
    {
        print(collision);
        if(collision.gameObject.tag == "Water")
        {
            print("Test");
            Player.transform.position = new Vector3(64.8f, 0.2f, -14.9f);
        }
    }
}
