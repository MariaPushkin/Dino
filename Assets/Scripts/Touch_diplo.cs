using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_diplo : MonoBehaviour {

    Animator anim;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseUp()
    {
        anim.CrossFade("Touching",5,1);
    }
}
