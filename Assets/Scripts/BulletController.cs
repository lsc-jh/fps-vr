using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public static float bulletSpeed = 1000f;
    private static int bulletDamage = 100;

    public static int Damnage { get { return bulletDamage = 100; } set { bulletDamage = value; } }


    private void OnTriggerEnter(Collider other)
    {
        ObjectPools.Instance.ReturnToPool(this);
    }
}
