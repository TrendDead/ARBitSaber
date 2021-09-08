using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactionToAction : MonoBehaviour
{
    [SerializeField]
    private Image _image;

    private int _score;
    private Player _player;

    private void Awake()
    {
        _score = 0;
        _player = GetComponent<Player>();
        ReturnColor();
    }

    private void OnEnable()
    {
        _player.ScoreUpdated += OnChangeColor;
    }

    private void OnDisable()
    {
        _player.ScoreUpdated -= OnChangeColor;
    }
    public void OnChangeColor(int score)
    {
        if (_score > score)
            _image.color = new Color(0.5f, 0, 0, 0.5f);
        else 
        if (_score < score)
            _image.color = new Color(0, 0.5f, 0, 0.5f);
        _score = score;
        StartCoroutine(TimeToColorChange());
    }

    private void ReturnColor()
    {
        _image.color = new Color(1, 1, 1, 0);
    }

    private IEnumerator TimeToColorChange()
    {
        yield return new WaitForSeconds(0.3f);
        ReturnColor();
    }
}
