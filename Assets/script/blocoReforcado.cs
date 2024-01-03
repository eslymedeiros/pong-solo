using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class blocoReforcado : MonoBehaviour
{
    private SpriteRenderer _renderer;
    public int hp = 3;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out _renderer);
    }

    // Update is called once per frame
    public void TomouHit()
    {
        hp--;
        _renderer.color *= 1.5f;
        if (hp <= 0){
            Destroy(gameObject);
        }
    }
}
