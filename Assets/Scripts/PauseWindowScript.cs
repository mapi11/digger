using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseWindowScript : MonoBehaviour
{
    [SerializeField] private GameObject _parent;
    [SerializeField] private GameObject _pauseWindow;

    ManagerSceneScript _managerScene;

    private void Start()
    {
        _managerScene = GetComponent<ManagerSceneScript>();

        _parent = GameObject.Find("Main canvas");
    }

    public void Pause()
    {
        Instantiate(_pauseWindow, _parent.transform.position, _parent.transform.rotation, _parent.transform);
    }

    public void Resume()
    {
        Destroy(_pauseWindow);
    }
}
