using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class loading : MonoBehaviour {

    IEnumerator Start()
    {
        AsyncOperation async = Application.LoadLevelAsync("workspace");
        yield return async;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
