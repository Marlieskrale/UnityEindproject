using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTest : MonoBehaviour
{
    public float force;

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
