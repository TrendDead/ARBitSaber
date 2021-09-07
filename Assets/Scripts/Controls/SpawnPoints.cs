using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpawnPoints
{
    public float _timeSpawn;
    public positionToSpawn _positionSpawn;
    public objectToSpawn _objectToSpawn;
    public enum positionToSpawn { UpLeft, UpMid, UpRight, MidLeft, MidMid, MidRight, BotLeft, BotMid, BotRight };
    public enum objectToSpawn { Ring, Bomb };
}
