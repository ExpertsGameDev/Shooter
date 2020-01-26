using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private bool _open;
    private Animator doorAnim;

    private void Start() {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    public void Operate()
    {
        if (_open)
        {
            transform.Rotate(0, 90, 0);
        }
        else
        {
            transform.Rotate(0, -90, 0);
        }
        _open = !_open;
    }

    public void Open()
    {
        doorAnim.SetBool("ParOpen", true);
    }

    public void Close()
    {
        doorAnim.SetBool("ParOpen", false);
    }
    
}
