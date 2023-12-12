using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movinanim : MonoBehaviour
{
    private void Update()

    {
        float distance = 20f;
        float speed = 2f;

        float yPos = transform.position.y;
        float zPos = transform.position.z;
        float xPos = Mathf.Sin(Time.time * speed) * distance;
    }
}
