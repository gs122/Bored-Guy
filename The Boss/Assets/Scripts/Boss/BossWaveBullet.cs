using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWaveBullet : MonoBehaviour
{

    BossWaveBulletSpawner bossWaveBulletSpawner;
    Vector3 m_centerPosition;
    Player player;
    public float m_speed;
    public float m_period;
    public float m_degrees;
    public float m_amplitude;


    // Start is called before the first frame update
    void Start()
    {
        m_centerPosition = gameObject.transform.position;
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        OutOfBounds();
        if (player.GetCanControl() == false)
        {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        float deltaTime = Time.deltaTime;

        // Move center along x axis
        m_centerPosition.x += deltaTime * m_speed;

        // Update degrees
        float degreesPerSecond = 360.0f / m_period;
        m_degrees = Mathf.Repeat(m_degrees + (deltaTime * degreesPerSecond), 360.0f);
        float radians = m_degrees * Mathf.Deg2Rad;

        // Offset by sin wave
        Vector3 offset = new Vector3(0.0f, m_amplitude * Mathf.Sin(radians), 0.0f);
        transform.position = m_centerPosition + offset;
    }

    private void OutOfBounds()
    {
        if ((gameObject.transform.position.y < -7.5) || (gameObject.transform.position.y > 7.5))
        {
            Destroy(gameObject);
        }
        if ((gameObject.transform.position.x < -25.5) || (gameObject.transform.position.x > 17.5))
        {
            Destroy(gameObject);
        }
    }

}
