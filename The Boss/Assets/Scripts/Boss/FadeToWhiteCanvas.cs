using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeToWhiteCanvas : MonoBehaviour
{

    private Image image;
    [SerializeField] float currentAlpha;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        var tempColor = image.color;
        tempColor.a = currentAlpha;
        image.color = tempColor;
    }

    // Update is called once per frame
    void Update()
    {
        var tempColor = image.color;
        tempColor.a = currentAlpha;
        image.color = tempColor;
    }


    public void FadeOut()
    {
        if (currentAlpha < 1)
        {
            currentAlpha += 0.01f;
            Invoke("FadeOut", 0.0001f);
        }

    }

    public void FadeIn()
    {
        currentAlpha = 0;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
