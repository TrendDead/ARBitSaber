using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _scoreViewNow;
    [SerializeField]
    private TMP_Text _scoreViewMax;
    [SerializeField]
    private Player _player;


    private int _scoreNow;
    private int _scoreMax = -1000;
    private void OnEnable()
    {
        _scoreNow = _player.Score;
        _scoreMax = PlayerPrefs.GetInt("MaxScore");

        if (_scoreNow > _scoreMax)
        {
            _scoreMax = _scoreNow;
            PlayerPrefs.SetInt("MaxScore", _scoreMax);
            PlayerPrefs.Save();
        }

        _scoreViewNow.text = _scoreNow.ToString();
        _scoreViewMax.text = _scoreMax.ToString();
    }

    public void ReloadScene()
    {
        Application.LoadLevel(0);
    }
}
