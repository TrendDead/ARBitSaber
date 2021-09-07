using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float _timeBeforeStart;

    [SerializeField]
    private Ring _ringTemplate;
    [SerializeField]
    private Bomb _bombTemplate;
    [SerializeField]
    private SpawnPoint[] _spawnPoints;
    [SerializeField]
    private List<SpawnPoints> _whenWereWhatSpawn;

    private float _timeGame;

    private void Awake()
    {
        _timeGame = _timeBeforeStart;
        SortList(_whenWereWhatSpawn);
    }

    private void Update()
    {
        _timeGame += Time.deltaTime;
        if (_whenWereWhatSpawn.Count > 0 && _timeGame >= _whenWereWhatSpawn[0]._timeSpawn)
        {
            Spawn();
            Debug.Log(_timeGame);
            Debug.Log("_timeGame");
        }
    }

    private void Spawn()
    {
        GameObject spawnObject = null;
        Transform spawnTransform = null;

        switch (_whenWereWhatSpawn[0]._objectToSpawn.ToString())
        {
            case "Ring":
                spawnObject = _ringTemplate.gameObject;
                break;            
            case "Bomb":
                spawnObject = _bombTemplate.gameObject;
                break;
        }
        
        switch (_whenWereWhatSpawn[0]._positionSpawn.ToString())
        {
            case "UpLeft":
                spawnTransform = _spawnPoints[0].transform;
                break;            
            case "UpMid":
                spawnTransform = _spawnPoints[1].transform;
                break;
            case "UpRight":
                spawnTransform = _spawnPoints[2].transform;
                break;            
            case "MidLeft":
                spawnTransform = _spawnPoints[3].transform;
                break;
            case "MidMid":
                spawnTransform = _spawnPoints[4].transform;
                break;            
            case "MidRight":
                spawnTransform = _spawnPoints[5].transform;
                break;
            case "BotLeft":
                spawnTransform = _spawnPoints[6].transform;
                break;            
            case "BotMid":
                spawnTransform = _spawnPoints[7].transform;
                break;            
            case "BotRight":
                spawnTransform = _spawnPoints[8].transform;
                break;
        }

        Instantiate(spawnObject, spawnTransform.position, Quaternion.identity);
        _whenWereWhatSpawn.RemoveAt(0);
    }

    private void SortList (List<SpawnPoints> array)
    {
        for (int i = array.Count - 1; i > 0; i--)
            for (int j = 1; j <= i; j++)
            {
                var element1 = array[j - 1]._timeSpawn;
                var element2 = array[j]._timeSpawn;
                if (element1 > element2)
                {
                    var temporary = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temporary;
                }
            }
    }
}
