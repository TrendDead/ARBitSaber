using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    public float SpeedScene;

    [SerializeField]
    private AudioSource _music;
    [SerializeField]
    private TMP_Text _scoreView;
    [SerializeField]
    private Spawner _spawnSistem;
    [SerializeField]
    private GameObject _buttonStart;
    [SerializeField]
    private EndGame _endGame;
    [SerializeField]
    private float _timeToPlay;

    private float _gameTime;
    private bool _startGame = false;

    public void StartGame()
    {
        _spawnSistem.gameObject.SetActive(true);
        _scoreView.gameObject.SetActive(true);
        _music.gameObject.SetActive(true);
        _buttonStart.gameObject.SetActive(false);
        _gameTime = 0;
        _startGame = true;
    }

    private void Update()
    {
        if (_startGame) _gameTime += Time.deltaTime;
        if (_gameTime >= _timeToPlay) EndGame();
    }

    private void EndGame()
    {
        _scoreView.gameObject.SetActive(false);
        _endGame.gameObject.SetActive(true);
    }
}
