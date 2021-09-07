using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bomb : MonoBehaviour
{
    private SceneControl _speedRing;
    private int _damage; //урон возвращающийся от бомбы
    void Start()
    {
        _speedRing = FindObjectOfType<SceneControl>();
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -1f) * _speedRing.SpeedScene;
    }

    private void Update()
    {
        if (transform.position.z < 0.1f)
            DestructionByPosition();
    }
    public int DestructionByThePlayer() //добавить эффект взрыва
    {
        Destroy(gameObject);
        return _damage; 
    }

    private void DestructionByPosition()
    {
        Destroy(gameObject);
    }
}
