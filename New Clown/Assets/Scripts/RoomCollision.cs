using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCollision : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            print("trocaPos");
            CameraController.instance.SetPosition(new Vector2(this.transform.position.x, this.transform.position.y));
        }
    }
}
