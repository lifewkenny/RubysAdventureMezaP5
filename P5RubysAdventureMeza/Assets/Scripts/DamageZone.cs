using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        RubyController controlller = other.GetComponent<RubyController>();

        if(controlller != null )
        {
            controlller.ChangeHealth(-1);
        }
    }
}
