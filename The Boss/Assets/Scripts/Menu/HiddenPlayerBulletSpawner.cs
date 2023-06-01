using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenPlayerBulletSpawner : MonoBehaviour
{

    [SerializeField] GameObject hiddenPlayerBullet;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("CreateHiddenPlayerBullet", 0.0f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateHiddenPlayerBullet()
    {
        Debug.Log("HiddenPlayerBullet created");
        Instantiate(hiddenPlayerBullet, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
    }
}
