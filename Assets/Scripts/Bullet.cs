using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bullet;
    public GameObject LelieSpawn;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "WaterTexture")
        {
            Instantiate(LelieSpawn, transform.position, Quaternion.LookRotation(new Vector3(Random.Range(-1, 1), 0,Random.Range(-1,1)),new Vector3(0,1,0)));
            Destroy(gameObject);
        }
    }
}
