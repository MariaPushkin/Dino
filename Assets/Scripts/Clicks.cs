using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Vuforia
{
    public class Clicks : MonoBehaviour
    {
        public void loadAR()
        {
            SceneManager.LoadScene(2);
        }

        public void loadBack(int a)
        {
            if (a == 1)
                Application.LoadLevel("menu");
            if (1 == 2)
                Application.LoadLevel("workspace");
            if (a == 3)
                Application.LoadLevel("library");
        }


        public void ChangeScene(string a)
        {
            Application.LoadLevel(a);
        }

        public void Close()
        {
            Application.Quit();
        }

    }
}

 
