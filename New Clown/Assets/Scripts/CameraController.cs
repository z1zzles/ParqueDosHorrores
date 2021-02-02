using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else
        {
            Destroy(instance);
        }
    }

    public void SetPosition(Vector2 position)
    {
        transform.position = Vector3.Lerp(CameraController.instance.transform.position, new Vector3(position.x, position.y, -10), Time.deltaTime * 1.2f);
    }
}
