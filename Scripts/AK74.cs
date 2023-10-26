using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK74 : Weapon
{
    public override void Shoot()
    {
        Instantiate(Bullet, _shootPoint.transform.position, _shootPoint.transform.rotation);
    }
}
