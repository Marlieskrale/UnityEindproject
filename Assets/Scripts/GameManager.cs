using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int remainingShots = 0;
    public Transform shotText;

    private void Start()
    {
        shotText.GetComponent<Text>().text = remainingShots.ToString();
    }
    private void Update()
    {
        shotText.GetComponent<Text>().text = remainingShots.ToString();
    }
}
