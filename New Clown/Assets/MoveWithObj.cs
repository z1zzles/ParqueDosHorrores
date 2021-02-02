using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithObj : MonoBehaviour
{
    [SerializeField]
    private GameObject target;
    void Update()
    {
        transform.position = target.transform.position;    
    }
}
