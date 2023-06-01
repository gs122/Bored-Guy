using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHandler : MonoBehaviour
{

    Vector2 startingPosition;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = (Vector2) transform.position;
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveToRandomPosition(float xLowerBound, float xUpperBound, float yLowerBound, float yUpperBound)
    {

        float randXOffset = Random.Range(xLowerBound, xUpperBound);
        float randYOffset = Random.Range(yLowerBound, yUpperBound);

        Vector3 newPosition = new Vector3(startingPosition.x + randXOffset, startingPosition.y + randYOffset, 0f);
        transform.position = newPosition;
        Debug.Log(newPosition);
    }

    public void MoveToStartingPosition()
    {
        transform.position = startingPosition;
    }
}

