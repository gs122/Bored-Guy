using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuArrow : MonoBehaviour
{

    Camera mainCamera;
    Canvas canvas;
    Selection selection;
    int currentSelectionIndex;

    // Start is called before the first frame update
    void Start()
    {
        canvas = FindObjectOfType<Canvas>();
        mainCamera = FindObjectOfType<Camera>();
        selection = FindObjectOfType<Selection>();
        currentSelectionIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PointToSelection();
    }

    private void PointToSelection()
    {

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentSelectionIndex++;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            currentSelectionIndex--;
        }

    }

    public Vector2 WorldToUISpace(Canvas parentCanvas, Vector2 worldPos)
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(worldPos);
        Vector2 movePos;

        
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvas.transform as RectTransform, screenPos, parentCanvas.worldCamera, out movePos);
        return parentCanvas.transform.TransformPoint(movePos);
    }

}
