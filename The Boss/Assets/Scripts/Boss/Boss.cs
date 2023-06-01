using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    [SerializeField] BossAimBullet bossAimBullet;
    [SerializeField] BossLaserHandler bossLaserHandler;
    [SerializeField] float aimBulletFireRate;
    [SerializeField] float createBossLaserHandlerRate;
    [SerializeField] float aimBulletSpeed;
    [SerializeField] int hp;
    [SerializeField] Sprite bossHurt;
    AudioSource audioSource;
    Animator bossAnimator;
    bool shootingAimBullets;
    bool creatingBossLaserHandlers;
    bool canShootAimBullet;
    bool canCreateBossLaserHandler;
    bool canBeDamaged;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        bossAnimator = GetComponent<Animator>();
        bossAnimator.Play("BossHelixWave", 0);
        canShootAimBullet = true;
    }

    void Update()
    { 
        ShootAimBullets();
        CreateBossLaserHandlers();
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.layer == LayerMask.NameToLayer("PlayerBullet"))
        {
            TakeDamage();
        }
        
    }

    private void ShootAimBullets()
    {
        if (shootingAimBullets)
        {
            if (canShootAimBullet)
            {
                CreateBossAimBullet();
                canShootAimBullet = false;
                Invoke("CanShoot", aimBulletFireRate);
            }
        }
    }

    private void CreateBossLaserHandlers()
    {
        if (creatingBossLaserHandlers)
        {
            CreateBossLaserHandler();
            canCreateBossLaserHandler = false;
            Invoke("CanCreateBossLaserHandler", createBossLaserHandlerRate);
        }
    }

    private void CanShoot()
    {
        canShootAimBullet = true;
    }
    
    private void CanCreateBossLaserHandler()
    {
        canCreateBossLaserHandler = true;
    }
    
    public void CreateBossAimBullet()
    {
        BossAimBullet newAimBullet = Instantiate(bossAimBullet, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
        newAimBullet.SetMoveSpeed(aimBulletSpeed);
    }

    public void CreateBossLaserHandler()
    {
        Instantiate(bossLaserHandler, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
    }
    
    public void TakeContinDamage()
    {
        InvokeRepeating("TakeDamage", 0f, 0.1f);
    }

    public void TakeDamage()
    {
        hp--;
        bossAnimator.SetTrigger("Hurt");
        Debug.Log(hp);
    }

    public void StopContinDamage()
    {
        CancelInvoke();
    }

    public void MakeHappy()
    {
        bossAnimator.SetTrigger("BossHappy");
    }

    public void SetShootingAimBullets(bool setTo)
    {
        shootingAimBullets = setTo;
        bossAnimator.SetBool("shootingAimBullets", setTo);
    }

    public void SetAimBulletFireRate(float newAimBulletFireRate)
    {
        aimBulletFireRate = newAimBulletFireRate;
    }

    public void SetAimBulletSpeed(float aimBulletsSpeed)
    {
        aimBulletSpeed = aimBulletsSpeed;
    }

    public void SetCreatingBossLaserHandlers(bool isCreatingBossLaserHandler)
    {
        creatingBossLaserHandlers = isCreatingBossLaserHandler;
    }

    public void SetAnimationSpeed(float newSpeed)
    {
        Animation anim = GetComponent<Animation>();
        foreach (AnimationState state in anim)
        {
            state.speed = newSpeed;
        }
    }

    public float GetAnimationSpeed()
    {
        return bossAnimator.speed;
    }

    public Animator GetAnimator()
    {
        return bossAnimator;
    }

    public int GetHp()
    {
        return hp;
    }

    public void SetHp(int newHp)
    {
        hp = newHp;
    }

    public void SetCanBeDamaged(bool newCanBeDamaged)
    {
        canBeDamaged = newCanBeDamaged;
    }
}

