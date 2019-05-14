using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{

    public float movementSpeed;
    public Rigidbody2D myRB2D;
    public int bulletDamage;
    // Start is called before the first frame update
    void Start()
    {
        myRB2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myRB2D.velocity = transform.right * movementSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {

            //do nothing
        }
        else if (other.tag == "Enemy")
        {
            //do damage
            other.GetComponent<EnemyHealthController>().TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
