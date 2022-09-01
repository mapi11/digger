using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;

public class SoundManagerScript : MonoBehaviour
{
    private bool muted = false;

    //[SerializeField] private GameObject _parentMusic;
    //[SerializeField] private GameObject _randomMusic;
    //public GameObject[] _sceneMusic = new GameObject[0];


    //private void Start()
    //{
    //    _parentMusic = GameObject.Find("Main canvas");
    //}

    //private void Update()
    //{
    //    _sceneMusic = GameObject.FindGameObjectsWithTag("Music");
    //}

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }

        else
        {
            muted = false;
            AudioListener.pause = false;
        }
    }


    //public void ChangeMusic()
    //{
    //    Destroy(_sceneMusic[0]);

    //    Instantiate(_randomMusic, _parentMusic.transform.position, _parentMusic.transform.rotation, _parentMusic.transform);
    //}
}
