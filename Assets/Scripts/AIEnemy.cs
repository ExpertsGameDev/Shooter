using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    public float speed = 1.0f;
    public int damage = 2;
    public float maxDistance = 10.0f;
    public float minDistance = 1.0f;
    public float distance;
    private bool _alive;
    public Transform target;
    public PlayerCharacter player;

    private void Start()
    {
        _alive = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (_alive)
        {
            distance = Vector3.Distance(transform.position, target.position);
            if (distance > maxDistance)
            {
                transform.Translate(0, 0, speed * Time.deltaTime);
            }
            if (distance < maxDistance && distance > minDistance) 
            {
                transform.rotation = Quaternion.Slerp(transform.localRotation, Quaternion.LookRotation(target.position - transform.position), speed * Time.deltaTime);
                transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
            }
            if (distance < minDistance)
            {
                player.Hurt(damage);
            }
        }
    }

    public void SetActive(bool alive)
    {
        _alive = alive;
    }

}
