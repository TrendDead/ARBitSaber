using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ring : MonoBehaviour
{
    private SceneControl _speedRing;
    void Start()
    {
        _speedRing = FindObjectOfType<SceneControl>();
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -1f) * _speedRing.SpeedScene;
    }

}
