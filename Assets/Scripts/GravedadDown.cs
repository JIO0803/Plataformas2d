using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GravedadDown : MonoBehaviour
{
    private BoxCollider2D collision;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 5;
            collision.gameObject.GetComponent<Movjugador>().salto = 2.5f;
            collision.transform.localScale = new Vector2(1, 1);
        }

        if (gameObject.tag == "botongrav" && collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}   