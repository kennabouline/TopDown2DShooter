using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chronometer : MonoBehaviour
{
    public float timer;
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timeText.text = timer.ToString("00.00");
    }
}
