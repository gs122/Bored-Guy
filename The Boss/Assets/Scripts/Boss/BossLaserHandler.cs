using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLaserHandler : MonoBehaviour
{

    Player player;
    BossLaser bossLaser;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        bossLaser = gameObject.GetComponentInChildren<BossLaser>();

        PointAtPlayer();

        Invoke("CreateLaser", 0.5f);
        bossLaser.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetCanControl() == false)
        {
            Destroy(gameObject);
        }
    }

    private void PointAtPlayer()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 thisPos = transform.position;
        playerPos.x = playerPos.x - thisPos.x;
        playerPos.y = playerPos.y - thisPos.y;
        float angle = Mathf.Atan2(playerPos.y, playerPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + 90));
    }

    private void CreateLaser()
    {
        bossLaser.gameObject.SetActive(true);
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }



}
