using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _text;

    private Score score;

    private void Start()
    {
        score = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ring box))
        {
            score.AddScore();
            Destroy(box.gameObject);
        }
        else
        {
            Bomb bomb = other.gameObject.GetComponentInParent<Bomb>();
            if (bomb != null)
            {
                score.AddScore(-10);
                Destroy(bomb.gameObject);
            }
        }
    }


}
