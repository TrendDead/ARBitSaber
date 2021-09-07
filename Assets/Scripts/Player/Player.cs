using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _hitpoints;
    private int _score;

    private void Start()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ring ring))
        {
            _score += ring.DestructionByThePlayer();
        }
        if (other.TryGetComponent(out Bomb bomb))
        {
            _hitpoints -= bomb.DestructionByThePlayer();
        }
    }


}
