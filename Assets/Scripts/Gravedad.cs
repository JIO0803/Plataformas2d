using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Gravedad : MonoBehaviour
{
    private BoxCollider2D collision;
    bool activado;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Metocahte");
        if (collision.gameObject.tag == "Player" && activado == true)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = collision.gameObject.GetComponent<Rigidbody2D>().gravityScale * -1;
            collision.gameObject.GetComponent<Movjugador>().salto = collision.gameObject.GetComponent<Movjugador>().salto * -1;
        }
    }
}
