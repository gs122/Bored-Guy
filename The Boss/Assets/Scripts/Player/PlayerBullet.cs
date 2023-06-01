using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] float explosionScale;
    [SerializeField] AudioClip explosion;
    private float current_x_position;
    private float current_y_position;
    Animator playerBulletAnimator;
    AudioSource audioSource;

    void Start()
    {
        playerBulletAnimator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Move();
        DestroyIfOutOfBounds();
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.layer == LayerMask.NameToLayer("Boss"))
        { 
            moveSpeed = 0;
            audioSource.PlayOneShot(explosion);
            playerBulletAnimator.SetTrigger("PlayerBulletDestroy");
            transform.rotation = Quaternion.Euler(0,0,Random.Range(0.0f, 360.0f));
            gameObject.transform.localScale = new Vector2(explosionScale, explosionScale);
        }
    }

    private void Move()
    {
        transform.position += (Vector3.up * moveSpeed * Time.deltaTime);
    }

    private void DestroyIfOutOfBounds()
    {
        if (gameObject.transform.position.y > 7.7f)
        {
            Destroy(gameObject);
        }
    }

}
