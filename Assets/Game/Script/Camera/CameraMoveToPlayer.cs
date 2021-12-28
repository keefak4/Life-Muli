using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveToPlayer : MonoBehaviour
{
    [SerializeField] private GameObject playerTarget;
    private void Update()
    {
        transform.position = new Vector3(playerTarget.transform.position.x, playerTarget.transform.position.y, transform.position.z);
    }
}
