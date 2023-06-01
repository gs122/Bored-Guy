using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    float amplitudeX;
    float amplitudeY;
    float omegaX;
    float omegaY; 
    float index;

    // Start is called before the first frame update
    void Start()
    {
        amplitudeX = 10.0f;
        amplitudeY = 5.0f;
        omegaX = 1.0f;
        omegaY = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        index += Time.deltaTime;
        float x = amplitudeX * Mathf.Cos(omegaX * index);
        float y = Mathf.Abs(amplitudeY * Mathf.Sin(omegaY * index));
        transform.localPosition = new Vector3(x, y, 0);
    }
}
