using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDPS : MonoBehaviour
{
    public void ReciewDamage()
    {
        Die();
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
