using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;
    private float bound = 2.55f;

    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        Vector3 currentPosition = transform.position;

        //going to the right side
        if (h > 0)
        {
            currentPosition.x += speed * Time.deltaTime;
        }
        if (h < 0)
        {
            currentPosition.x -= speed * Time.deltaTime;
        }

        if(currentPosition.x>bound)
        {
            currentPosition.x = bound;
        }
        else if(currentPosition.x<(-bound))
        {
            currentPosition.x = -bound;
        }
        transform.position = currentPosition;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag=="Bomb")
        {
            Time.timeScale = 0f;
        }
    }
}
