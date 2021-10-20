using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;

    //Score System
    private int Score;
    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        //Moving Up
        if (verticalInput > 0)
        {
            if (transform.position.y < 3.9)
            {
                transform.position = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);
            }
        }
        //Moving Down
        if (verticalInput < 0)
        {
            if (transform.position.y > -3.9)
            {
                transform.position = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);
            }
        }

        //Score Text Update
        ScoreText.text = "Score: " + Score;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Obstacle")
        {
            Score++;
        }
    }
}
