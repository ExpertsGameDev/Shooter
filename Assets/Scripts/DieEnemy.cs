using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEnemy : MonoBehaviour
{
    public void ReactToHit()
    {//метод, вызванный сценарием стрельбы
        AIEnemy behaviour = GetComponent<AIEnemy>();
        if(behaviour != null)
        {
            behaviour.SetActive(false);
        }
        StartCoroutine(Die()); //вызываем сопрограмму Die()
    }


    private IEnumerator Die()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }

}
