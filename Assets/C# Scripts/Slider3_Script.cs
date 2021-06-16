using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider3_Script : MonoBehaviour
{
    private bool shouldLerp = false;
    private bool negShouldLerp = false;

    public float timeStartedLerping;
    public float lerpTime;

    public Vector2 startPos;
    public Vector2 endPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (shouldLerp)
        {

            transform.position = Lerp(startPos, endPos, timeStartedLerping, lerpTime);

        }
        else if (negShouldLerp)
        {

            transform.position = Lerp(endPos, startPos, timeStartedLerping, lerpTime);

        }

    }

    public void startLerping()
    {
        negShouldLerp = false;
        timeStartedLerping = Time.time;
        shouldLerp = true;
    }

    public void startNegLerping()
    {
        shouldLerp = false;
        timeStartedLerping = Time.time;
        negShouldLerp = true;
    }

    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 1)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;

        float percentageComplete = timeSinceStarted / lerpTime;

        var result = Vector3.Lerp(start, end, percentageComplete);

        return result;
    }
}
