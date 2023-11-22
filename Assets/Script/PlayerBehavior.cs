using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerBehavior : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    int score;
    public TextMeshProUGUI scoreText;
    public GameObject GameWonUI;
    public GameObject GameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        TouchMove();
    }
    void Awake()
    {
        
    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (mousePos.x < 0)
            {

                rb.velocity = Vector2.left * speed;
            }
            else if (mousePos.x > 0)
            {
                rb.velocity = Vector2.right * speed;
            }

        }

        else
        {

            rb.velocity = Vector2.zero;
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Coin"))
            {
                Destroy(collision.gameObject);
                score++;
                UpdateScoreText();
                if (score == 5)
                {

                    GameWonUI.SetActive(true);
                }
            }
            else if (collision.gameObject.CompareTag("Sun"))
            {
                speed = 0;
                GameOverUI.SetActive(true);

            }
        }
        void UpdateScoreText()
        {
            scoreText.text = score.ToString();
        }
    }
}
