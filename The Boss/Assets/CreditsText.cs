using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsText : MonoBehaviour
{

    [SerializeField] float scrollSpeed;
    private bool scrolling;

    // Start is called before the first frame update
    void Start()
    {
        scrolling = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (scrolling)
        {
            Debug.Log("Should be scrolling up");
            float newYPosition = transform.position.y + scrollSpeed;
            transform.position = new Vector2(transform.position.x, newYPosition);
            //transform.position = new Vector3(0f, 0f, 0f);
        }
    }

    public void SetScrolling(bool newScrolling)
    {
        scrolling = newScrolling;
    }
}
