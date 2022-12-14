using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidL : MonoBehaviour
{
    public float velocidad; //VELOCIDAD CON EL QUE SE MOVERA EL OBSTACULO

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocidad * Time.deltaTime; //DIRRECCIÓN DONDE SE MUEVE EL OBSTACULO
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "nave")
        {
            Player playerController = other.gameObject.GetComponent<Player>();
            playerController.Hurt(1);
            Destroy(gameObject);
        }
        if (other.tag == "laser")
        {
            Destroy(gameObject);
        }
    }
}
