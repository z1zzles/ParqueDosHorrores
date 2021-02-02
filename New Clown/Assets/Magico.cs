using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magico : MonoBehaviour
{
    public GameObject magia;
    public float fireRate;
    float proximoTiro = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tiro();
    }

    void Tiro()
    {
        if (Time.time > proximoTiro)
        {
            //Reload no cooldown
            proximoTiro = Time.time + fireRate;

            //Spawna Tiro
            Instantiate(magia, transform.position, Quaternion.identity);
        }
    }
}
