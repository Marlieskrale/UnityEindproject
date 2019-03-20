using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    public float bulletSpeed = 10;
    public GameObject bullet;
    public Transform gunEnd;
    public GameObject LelieSpawn;


    void Fire()
    {
        GameObject bulletClone = Instantiate(bullet);
        bulletClone.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
        bulletClone.transform.position = gunEnd.position;
        bulletClone.transform.eulerAngles = gunEnd.eulerAngles;
        Destroy(bulletClone, 5);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Fire();
    }

}