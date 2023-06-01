using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurt : MonoBehaviour
{

    [SerializeField] AudioClip hurtSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayHurtSound()
    {
        GetComponent<AudioSource>().Play();
    }
}
