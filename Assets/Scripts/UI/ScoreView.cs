using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _scoreView;

    private Player _player;

    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void OnEnable()
    {
        _player.ScoreUpdated += OnChangeValueScore;
    }

    private void OnDisable()
    {
        _player.ScoreUpdated -= OnChangeValueScore;
    }
    public void OnChangeValueScore(int score)
    {
        _scoreView.text = score.ToString();
    }
}
