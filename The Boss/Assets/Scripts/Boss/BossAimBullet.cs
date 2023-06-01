using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAimBullet : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    Player player;
    Vector3 playerPosition;
    Vector3 movementVector = Vector3.zero;
    CapsuleCollider2D capsuleCollider2D;

    // Start is called before the first frame update
    void Start()
    {
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
        player = FindObjectOfType<Player>();
        playerPosition = player.transform.position;
        movementVector = (playerPosition - gameObject.transform.position).normalized * moveSpeed;
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
        transform.position += movementVector * Time.deltaTime;
    }

    private void OutOfBounds()
    {
        if ((gameObject.transform.position.y < -7.5) || (gameObject.transform.position.y > 7.5))
        {
            Destroy(gameObject);
        }
        if ((gameObject.transform.position.x < -12.5) || (gameObject.transform.position.x > 12.5))
        {
            Destroy(gameObject);
        }
    }

    public void SetMoveSpeed(float newMoveSpeed)
    {
        moveSpeed = newMoveSpeed;
    }

}
