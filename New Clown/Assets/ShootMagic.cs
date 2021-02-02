using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMagic : MonoBehaviour
{
    public float velocidadeMagia;

    Rigidbody2D rb;

    public GameObject alvo;
    Vector2 direcao;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        alvo = GameObject.FindGameObjectWithTag("Player");
        direcao = (alvo.transform.position - transform.position) * velocidadeMagia;
        rb.velocity = new Vector2(direcao.x, direcao.y);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
