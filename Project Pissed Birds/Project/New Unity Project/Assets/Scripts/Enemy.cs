using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _cloudParticlePreFab;

   private void OnCollisionEnter2D(Collision2D collision)
    {  

         Bird bird = collision.collider.GetComponent<Bird>();
           if (bird!=null)
        {
            Instantiate(_cloudParticlePreFab, transform.position, Quaternion.identity );
            Destroy(gameObject);
            return;
        }
                
        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            return; //if we hit an enemy, we're going to bail out.
        }

      /*  if(collision.contacts[0].normal.y < -0.5)
        {
            Destroy(gameObject);
        }*/

        if(collision.contacts[0].normal.y< -0.5 )
        {
            //<.5 is mostly on top
            //normal gives us the angle that we hit from
            //contact is to detect collision. It is an array because it deals with a number of collisions. But we're only interested in the first
            Instantiate(_cloudParticlePreFab, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }

    }
}
