using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb;
    public bool nochao; 
    public int forcapulo = 7;
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb); 
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (!nochao && collision.gameObject.tag == "chao")
        {
            nochao = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //-1 esquerda, 0 nada,1 direita
        float v = Input.GetAxis("Vertical"); // -1 trás, 0 nada, 1 frente

        Vector3 direcao = new Vector3(h, 0, v);
        rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.Space) && nochao)
        {
            rb.AddForce(Vector3.up * forcapulo, ForceMode.Impulse);
            nochao = false;
            
        }

        if (transform.position.y <= -1)
        {
            //jogador caiu
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
