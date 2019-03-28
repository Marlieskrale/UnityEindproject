using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public GameManager gm;
    public float bulletSpeed = 10;
    public GameObject bullet;
    public Transform gunEnd;
    public GameObject LelieSpawn;
    public AudioClip SoundClip;
    public AudioSource SoundSource;

    //public static float remainingShots = 10;
    //public static bool emptyShots = false;
    //public Transform shotText;


    void Start()
    {

        SoundSource.clip = SoundClip;
        //shotText.GetComponent<Text>().text = gm.remainingShots.ToString();
    }


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

        if (Input.GetButtonDown("Fire1") && gm.remainingShots > 0)
        {
            Fire();
            Debug.Log("fire");
            gm.remainingShots = gm.remainingShots - 1;
            //shotText.GetComponent<Text>().text = gm.remainingShots.ToString();

        }

        if (gm.remainingShots <= 0)
        {
            Debug.Log("geen ammo");
        }



        //if (remainingShots == 0) 
        //{
        //   emptyShots = true;
        //   Debug.Log("0 shots");
        //Input.GetButtonDown("Fire1") = false;
        //}

    }



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "WaterTexture")
        {
            //yield return new WaitForSeconds(1f);
            SoundSource.Play();
        }
    }

}