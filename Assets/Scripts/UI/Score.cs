using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField]
    private int _score = 0;
    [SerializeField]
    private TMP_Text _text;

    public void AddScore(int n = 1)
    {
        _score += n;
        _text.text = _score.ToString();
    }
}
