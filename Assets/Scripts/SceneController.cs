using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject _enemy;
    private GameObject player;

    void Update()
    {
        if(_enemy == null)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = gameObject.transform.position;
            player = GameObject.FindWithTag("Player");//находим объект с тегом “Player”
            _enemy.gameObject.GetComponent<AIEnemy>().target = player.transform;
            _enemy.gameObject.GetComponent<AIEnemy>().player = player.GetComponent<PlayerCharacter>();
        }
    }
}
