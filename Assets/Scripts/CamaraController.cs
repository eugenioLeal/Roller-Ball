using UnityEngine;
using System.Collections;

public class CamaraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;//get the distance between the camara and player(ball) for third person view

    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
