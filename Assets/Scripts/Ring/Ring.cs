using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ring : MonoBehaviour
{
    private SceneControl _speedRing;
    private int _score; //����� �� ���������� ������
    private int _damage; //���� �������������� �� �������� ������
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
    public int DestructionByThePlayer() //�������� ������
    {
        Debug.Log(Time.time);
        Debug.Log("player");
        Destroy(gameObject);
        return _score;
    }

    private void DestructionByPosition() //��������� ��� ���������� ���� ������
    {
        Debug.Log(Time.time);
        Debug.Log("pos");
        Destroy(gameObject);
    }
}
