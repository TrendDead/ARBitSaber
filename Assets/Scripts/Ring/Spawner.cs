using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Ring _ring;
    [SerializeField]
    private Bomb _bomb;
    [SerializeField] 
    private Vector2 _spawnRadius;
    [SerializeField]
    private float _secondsBetweenSpawnRing;
    [SerializeField]
    private float _secondsBetweenSpawnBomb;

    private void Start()
    {
        StartCoroutine(SpawnerRing());
        StartCoroutine(SpawnerBomb());
    }
    private IEnumerator SpawnerRing()
    {
        var _waitForSeconds = new WaitForSeconds(_secondsBetweenSpawnRing);

        while (true)
        {
            Instantiate(_ring,
                    gameObject.transform.position + new Vector3(Random.Range(-_spawnRadius.x, _spawnRadius.x),
                                                            Random.Range(-_spawnRadius.y, _spawnRadius.y),
                                                            0),
                    Quaternion.identity,
                    gameObject.transform);

            yield return _waitForSeconds;
        }
    }
    private IEnumerator SpawnerBomb()
    {
        var _waitForSeconds = new WaitForSeconds(_secondsBetweenSpawnBomb);

        while (true)
        {
            Instantiate(_bomb,
                    gameObject.transform.position + new Vector3(Random.Range(-_spawnRadius.x, _spawnRadius.x),
                                                            Random.Range(-_spawnRadius.y, _spawnRadius.y),
                                                            0),
                    Quaternion.identity,
                    gameObject.transform);

            yield return _waitForSeconds;
        }
    }

}
