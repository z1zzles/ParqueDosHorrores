using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSprite : MonoBehaviour
{
    private SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void FlipX(bool value) {
        sr.flipX = value;
    }

    public void FlipY(bool value)
    {
        sr.flipY = value;
    }
}
