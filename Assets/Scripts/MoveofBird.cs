using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveofBird : MonoBehaviour
{
    public Rigidbody2D rb2;
    [SerializeField] public float jumpAmount;
    public Text gameoverTxt;
    public Text scoreTxt;
    private int score;
    void Start()
    {
        gameoverTxt.gameObject.SetActive(false);
        rb2 = GetComponent<Rigidbody2D>();
        score = 0;
        scoreTxt.text = "Score: " + score;

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2.AddForce(transform.up * jumpAmount);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Pipe")
        {
            gameoverTxt.gameObject.SetActive(true);
            this.gameObject.SetActive(false);

        }
        if(collision.gameObject.tag == "Score")
        {
            score += 1;
            scoreTxt.text = "Score: " + score;
        }
    }

   
}
