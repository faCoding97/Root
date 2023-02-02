using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour
{
    private void OnMouseDown()
    {
        OnClick();
    }

    public virtual void OnClick()
    {
        Player.instance.MoveToLocation(transform.position);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Colided");
        if (other.tag == "Player")
        {
            PlayerCollision();
        }
    }

    public virtual void PlayerCollision()
    {

    }
}
