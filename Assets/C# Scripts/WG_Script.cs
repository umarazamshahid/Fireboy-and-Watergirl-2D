using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WG_Script : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if(FireDoor.GetComponent<FireDoor_Script>().isActivated && WaterDoor.GetComponent<WaterDoor_Script>().isActivated)
        {
            SceneManager.LoadScene(1);
        }
    }

    void Movement()
    {
        //Horizontal Movement (using Arrow Keys)
        transform.Translate(Input.GetAxis("ArrowHorizontal") * moveSpeed * Time.deltaTime, 0, 0);

        //Vertical Jump (Using Up Arrow Key)        
        transform.Translate(0, Input.GetAxis("ArrowVertical") * jumpForce * Time.deltaTime, 0);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lever"))
        {
            Lever.GetComponent<Lever_Script>().Activate();
            return;
        }

        if (collision.gameObject.CompareTag("Lever2"))
        {
            Lever2.GetComponent<Lever2_Script>().Activate();
            return;
        }

        if (collision.gameObject.CompareTag("Lever3"))
        {
            Lever3.GetComponent<Lever3_Script>().Activate();
            return;
        }

        if (collision.gameObject.CompareTag("Firepit"))
        {
            Die();
            return;
        }

        if (collision.gameObject.CompareTag("Goopit"))
        {
            Die();
            return;
        }

        if (collision.gameObject.CompareTag("WaterDiamond"))
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
        if (collision.gameObject.CompareTag("ButtonForSlider3"))
        {
            ButtonForSlider3.GetComponent<ButtonForSlider3>().Activate();
            return;
        }
        if (collision.gameObject.CompareTag("WaterDoor"))
        {
            WaterDoor.GetComponent<WaterDoor_Script>().ActivateDoor();
            return;
        }
    }
}
