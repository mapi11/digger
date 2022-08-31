using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyScript : MonoBehaviour
{
    private void Start()
    {
        GameObject[] _musicObj = GameObject.FindGameObjectsWithTag("Music");

        if (_musicObj.Length > 1)
        {
            Destroy(this.gameObject);

        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }



}
