using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPrefabScript : MonoBehaviour
{
    [SerializeField] private GameObject[] _prefab;
    [SerializeField] private GameObject _parent;
    private int _int;
    private void Start()
    {
        _int = Random.Range(0, _prefab.Length);
        Instantiate(_prefab[_int], transform.position, transform.rotation, _parent.transform);
    }
}
