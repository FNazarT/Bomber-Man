using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;
    float minX = -2.55f;
    float maxX = 2.55f;

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 currentPosition = transform.position;
        currentPosition.x += h * speed * Time.deltaTime;

        if (currentPosition.x < minX)
        {
            currentPosition.x = minX;
        }

        if(currentPosition.x > maxX)
        {
            currentPosition.x = maxX;
        }

        transform.position = currentPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bomb")
        {
            Time.timeScale = 0;
        }
    }
}
