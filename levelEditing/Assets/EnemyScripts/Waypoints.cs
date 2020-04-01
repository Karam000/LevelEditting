using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] Transform[] translist;

    public Transform[] Translist => translist;
    private void OnDrawGizmos()
    {
        if (translist == null)
            return;
       
        for (int i = 0; i < translist.Length; i++)
        {
             Gizmos.color = Color.red;
             Gizmos.DrawSphere(translist[i].position, 0.3f);
        }
        for (int i = 0; i < translist.Length-1; i++)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(translist[i].position, translist[i + 1].position);

        }

    }
}
