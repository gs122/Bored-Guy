using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{

    [SerializeField] Button startButton;
    Button lastSelectedButton;
    GameObject myEventSystem;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
        myEventSystem = GameObject.Find("EventSystem");
        myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(startButton.gameObject);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(startButton.gameObject);
        }
    }
}
