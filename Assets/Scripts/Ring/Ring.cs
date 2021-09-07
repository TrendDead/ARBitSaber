using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ring : MonoBehaviour
{
    private SceneControl _speedRing;
    private int _score; //Баллы от подбирания кольца
    private int _damage; //урон возвращающийся от пропуска кольца
    void Start()
    {
        _speedRing = FindObjectOfType<SceneControl>();
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -1f) * _speedRing.SpeedScene;
    }
    private void Update()
    {
        if (transform.position.z < -0.1f)
            DestructionByPosition();
    }
    public int DestructionByThePlayer() //Добавить эффект
    {
        Debug.Log(Time.time);
        Debug.Log("player");
        Destroy(gameObject);
        return _score;
    }

    private void DestructionByPosition() //придумать как передовать урон игроку
    {
        Debug.Log(Time.time);
        Debug.Log("pos");
        Destroy(gameObject);
    }
}
