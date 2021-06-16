using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonForSlider3 : MonoBehaviour
{
    public GameObject Slider3;
    bool isActivated = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Activate()
    {
        if (!isActivated)
        {
            Debug.Log("Activated 1");
            isActivated = true;
            //transform.Rotate(new Vector3(0, 0, transform.position.z + 2 * 44));
            Slider3.GetComponent<Slider3_Script>().startLerping();

        }
        else
        {
            Debug.Log("Activated 2");
            isActivated = false;
            //transform.Rotate(new Vector3(0, 0, transform.position.z - 2 * 44));
            Slider3.GetComponent<Slider3_Script>().startNegLerping();
        }
        //Slider1.GetComponent<Slider_Script>().startNegLerping();
    }
}
