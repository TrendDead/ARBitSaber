using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Ring : MonoBehaviour, ITouch
{
    [SerializeField]
    private int _scorePlus;
    [SerializeField]
    private int _scoreMinusCoff;

    [SerializeField]
    private Player _player;

    private SceneControl _speedRing;
    void Start()
    {
        _player = FindObjectOfType<Player>();
        _speedRing = FindObjectOfType<SceneControl>();
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -1f) * _speedRing.SpeedScene;
    }
    private void Update()
    {
        if (transform.position.z < -0.1f)
            DestructionByPosition();
    }
    public int DestructionByThePlayer()
    {
        Destroy(gameObject);
        return _scorePlus;
    }

    public void DestructionByPosition()
    {
        _player.ScoreChanger(this, _scoreMinusCoff * -1);
    }

}
