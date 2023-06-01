using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToCanvas : MonoBehaviour
{

    public RectTransform parent;
    public Camera UICamera;
    public RectTransform image;
    public Canvas canvas;
         
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 anchoredPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parent, new Vector3(0f, 0f, 0f), canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : UICamera, out anchoredPos);
        image.anchoredPosition = anchoredPos;
    }
}
