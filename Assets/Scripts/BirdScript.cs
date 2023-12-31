using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D RB;
    public float flapStrangth;
    public LogicManagerScript Logic;
    public bool isBirdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && isBirdAlive == true)
        {
            RB.velocity = Vector2.up * flapStrangth;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.GameOver();
        isBirdAlive = false;
    }



}
