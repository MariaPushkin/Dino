using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

    public float rotation_speed = 100.0f;
    private GameObject rotated_model; 
    bool repeatRotateLeft = false;
    bool repeatRotateRight = false;

    void start()
    {
        //rotated_model = GameObject.Find("dilo");
    }
	// Update is called once per frame
	void Update () {
        if (repeatRotateRight)
        {
            rotated_model.transform.Rotate(0, -rotation_speed * Time.deltaTime, 0);
        }

        if (repeatRotateLeft)
        {
            rotated_model.transform.Rotate(0, rotation_speed * Time.deltaTime, 0);
        }
    }

    public void RotationRightStart(GameObject a)
    {
        // transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
        //rotated_model.transform.Rotate(0, -rotation_speed * Time.deltaTime, 0);
        rotated_model = a;
        repeatRotateRight = true;
    }

    public void RotationLeftStart(GameObject a)
    {
        // transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
        //GameObject.FindWithTag("Model_Anjing").transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        rotated_model = a;
        repeatRotateLeft = true;
    }

    public void RotationRightFinish()
    {
        repeatRotateRight = false;
    }

    public void RotationLeftFinish()
    {
        repeatRotateLeft = false;
    }

}
