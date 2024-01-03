using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    private Rigidbody2D rb;
    public int velocidade = 10; 
    private Vector2 direcao;

    void Start()
    {
        TryGetComponent(out rb);
        direcao = Random.insideUnitCircle.normalized;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("bloco")){
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("chao")){
            GameManager.instance.ReiniciarCena();
        }
        if (collision.gameObject.CompareTag("reforcado")){
            collision.gameObject.GetComponent<blocoReforcado>().TomouHit();
        }
        direcao = Vector2.Reflect(direcao, collision.contacts[0].normal);
    }
    
    void Update()
    {
        rb.velocity = direcao * velocidade;
    }
}
