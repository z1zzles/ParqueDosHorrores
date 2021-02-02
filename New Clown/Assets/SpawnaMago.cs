using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnaMago : MonoBehaviour
{
    public GameObject mago;
    public float minX, maxX, minY, maxY;
    private float posicaoX, posicaoY;
    [SerializeField]
    private Vector2 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RandomNumbers();
    }

    private Vector2 RandomNumbers()
    {
        posicaoX = Random.Range(minX, maxX);
        posicaoY = Random.Range(minY, maxY);
        spawnPoint = new Vector2(posicaoX, posicaoY);
        return spawnPoint;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(mago, RandomNumbers(), Quaternion.identity);
        }
    }

}
