using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mimic : MonoBehaviour
{
    public GameObject player;
    public bool SegueX;
    public bool SegueY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SegueX == true)
        {
            transform.position = new Vector2(player.transform.position.x, transform.position.y);
        }

        if (SegueY == true)
        {
            transform.position = new Vector2(transform.position.x, player.transform.position.y);
        }
    }
}
