using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coinsANDsun : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); Coins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Coins() {
        Vector2 randomDirection = new Vector2(Random.Range(-1,1), 1);
    }
}

