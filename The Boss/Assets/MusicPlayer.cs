using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip dmgGuitar;
    [SerializeField] AudioClip skateboard;
    [SerializeField] AudioClip retroComedy;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayDmgGuitar();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayRetroComedy()
    {
        //audioSource.Stop();
        audioSource.clip = retroComedy;
        Debug.Log("Comedy should be playing");
        audioSource.Play();
    }

    public void PlayDmgGuitar()
    {
        //audioSource.Stop();
        Debug.Log("dmgGuitar should be playing");
        audioSource.clip = dmgGuitar;
        audioSource.Play();
    }

    

    public void PlaySkateboard()
    {
        audioSource.clip = skateboard;
        GetComponent<AudioSource>().volume = 0.25f;
        Debug.Log("Skateboard should be playing");
        audioSource.Play();
    }
}
