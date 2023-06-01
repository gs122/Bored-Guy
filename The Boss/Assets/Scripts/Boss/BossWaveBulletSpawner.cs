using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWaveBulletSpawner : MonoBehaviour
{

    [SerializeField] BossWaveBullet bossWaveBullet;
    [SerializeField] public float m_speed;
    [SerializeField] public float m_period;
    [SerializeField] public float m_degrees;
    [SerializeField] public float m_amplitude;
    private bool canShoot;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
        InvokeRepeating("SpawnBullet", 0f, 0.1f);
        InvokeRepeating("CanShootTrue", 0f, 2f);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnBullet()
    {
        if (canShoot)
        {
            BossWaveBullet newBullet = Instantiate(bossWaveBullet, gameObject.transform.position, Quaternion.identity);
            newBullet.m_speed = m_speed;
            newBullet.m_period = m_period;
            newBullet.m_degrees = m_degrees;
            newBullet.m_amplitude = m_amplitude;
        }
    }

    private void CanShootTrue()
    {
        canShoot = true;
        Invoke("CanShootFalse", 1f);

    }

    private void CanShootFalse()
    {
        canShoot = false;
    }
}
