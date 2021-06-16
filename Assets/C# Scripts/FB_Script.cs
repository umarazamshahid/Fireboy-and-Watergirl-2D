using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FB_Script : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public GameObject Lever;
    public GameObject Lever2;
    public GameObject Lever3;
    public GameObject WaterDoor;
    public GameObject FireDoor;
    public GameObject ButtonForSlider1;
    public GameObject ButtonForSlider2;
    public GameObject ButtonForSlider3;


    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        //Horizontal Movement (using WASD Keys)
        transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0);

        //Vertical Jump (Using W Key)        
        transform.Translate(0, Input.GetAxis("Vertical") * jumpForce * Time.deltaTime, 0);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lever"))
        {
            Lever.GetComponent<Lever_Script>().Activate();
            return;
        }

        if(collision.gameObject.CompareTag("Lever2"))
        {
            Lever2.GetComponent<Lever2_Script>().Activate();
            return;
        }

        if (collision.gameObject.CompareTag("Lever3"))
        {
            Lever3.GetComponent<Lever3_Script>().Activate();
            return;
        }

        if (collision.gameObject.CompareTag("Waterpit"))
        {
            Die();
            return;
        }

        if (collision.gameObject.CompareTag("Goopit"))
        {
            Die();
            return;
        }

        if (collision.gameObject.CompareTag("FireDiamond"))
        {
            Destroy(collision.gameObject);
            return;
        }

    }

    private void Die()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentLevel);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ButtonForSlider1"))
        {
            ButtonForSlider1.GetComponent<ButtonForSlider1>().Activate();
            return;
        }
        if (collision.gameObject.CompareTag("ButtonForSlider2"))
        {
            ButtonForSlider2.GetComponent<ButtonForSlider2>().Activate();
            return;
        }
        if(collision.gameObject.CompareTag("ButtonForSlider3"))
        {
            ButtonForSlider3.GetComponent<ButtonForSlider3>().Activate();
            return;
        }

        if (collision.gameObject.CompareTag("FireDoor"))
        {
            FireDoor.GetComponent<FireDoor_Script>().ActivateDoor();
            return;
        }

        



    }
}
