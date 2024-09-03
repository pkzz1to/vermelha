using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    private Transform alvo;
    public Vector3 offset; //distancia do alvo
    // Start is called before the first frame update
    void Start()
    {
        alvo = GameObject.FindWithTag("Player").transform; //pega a tag player como referencia de alvo
        offset = alvo.position - transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = alvo.position - offset;
    }
}
