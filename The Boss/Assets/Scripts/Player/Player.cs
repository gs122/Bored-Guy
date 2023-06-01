using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] PlayerBullet playerBullet;
    [SerializeField] bool canShoot;
    [SerializeField] float fireRate;
    [SerializeField] int hp;
    [SerializeField] AudioClip shootSound;
    [SerializeField] AudioClip hurtSound;
    AudioSource audioSource;
    CreditsText creditsText;
    Animator animator;
    BoxCollider2D boxCollider2D;
    Rigidbody2D playerRigidbody2D;
    DialogueManager dialogueManager;
    private float current_x_position;
    private float current_y_position;
    bool godMode;
    PlayerHealth playerHealth;
    [SerializeField] bool canControl;
    Boss boss;
    PlayerHurt playerHurt;

    void Start()
    {
        playerHurt = FindObjectOfType<PlayerHurt>();
        creditsText = FindObjectOfType<CreditsText>();
        playerHealth = FindObjectOfType<PlayerHealth>();
        audioSource = GetComponent<AudioSource>();
        godMode = false;
        dialogueManager = FindObjectOfType<DialogueManager>();
        boss = FindObjectOfType<Boss>();
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();

        // Delete the following
        Debug.Log(SceneManager.GetActiveScene().ToString());
    }

    void Update()
    {
        if (canControl)
        {
            Move();
            Shoot();
        }
        OutOfBounds();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogueManager.DisplayNextSentence();
            if (creditsText.transform.position.y >= 1872.83f)
            {
                SceneManager.LoadScene("StartMenu");
            }
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (boxCollider2D.IsTouchingLayers(LayerMask.GetMask("EnemyAttack")))
        {
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Intangible"))
            {
                TakeDamage();
                if (!collision.CompareTag("BossLaser"))
                {
                    Destroy(collision.gameObject);
                }
            } 
        }
    }



    private void Move()
    {
        current_x_position = transform.position.x;
        current_y_position = transform.position.y;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += (Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += (Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += (Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += (Vector3.down * moveSpeed * Time.deltaTime);
        }

    }

    private void Shoot()
    {
        if (canShoot)
        {
            if (Input.GetKey(KeyCode.S))
            {
                audioSource.volume = 0.1f;
                audioSource.PlayOneShot(shootSound);
                Instantiate(playerBullet, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y+0.5f) , Quaternion.identity);
                canShoot = false;
                Invoke("CanShoot", fireRate);
            }  
        }
    }

    private void OutOfBounds()
    {
        if (transform.position.x > 12.0f)
        {
            transform.position = new Vector2(12.0f, transform.position.y);
        }
        if (transform.position.x < -12.0f)
        {
            transform.position = new Vector2(-12.0f, transform.position.y);
        }
        if (transform.position.y > 6.5f)
        {
            transform.position = new Vector2(transform.position.x, 6.5f);
        }
        if (transform.position.y < -6.5f)
        {
            transform.position = new Vector2(transform.position.x, -6.5f);
        }
    }

    private void CanShoot()
    {
        canShoot = true;
    }

    public void MoveToRandomPosition()
    {
        float randXPosition = Random.Range(-9.5f, 9.5f);
        float randYPosition = Random.Range(-3f, 0.5f);
        Vector2 newPosition = new Vector2(randXPosition, randYPosition);
        transform.position = newPosition;
        Debug.Log(newPosition);
    }

    public void TakeDamage()
    {
        audioSource.volume = 0.5f;
        playerHurt.PlayHurtSound();
        animator.SetTrigger("Intangible");
        if (godMode == false)
        {
            hp--;
            playerHealth.GetComponent<Text>().text = "HP: " + hp.ToString();
            if (hp == 0)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void SetGodMode(bool isGodMode)
    {
        godMode = isGodMode;
    }

    public void SetCanControl(bool newCanControl)
    {
        canControl = newCanControl;
    }

    public bool GetCanControl()
    {
        return canControl;
    }

}


