using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private int _score;

    public int Score => _score;

    public event UnityAction<int> ScoreUpdated;

    private void Start()
    {
        ScoreUpdated?.Invoke(_score = 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ring ring))
        {
            ScoreChanger(ring);
        }
        else if (other.TryGetComponent(out Bomb bomb))
        {
            ScoreChanger(bomb);
        }
    }

    public void ScoreChanger(ITouch touchObject, int coefficent = 1)
    {
        _score += touchObject.DestructionByThePlayer() * coefficent;
        ScoreUpdated?.Invoke(_score);
    }

}
