using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    private Quaternion my_rotation;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        my_rotation = this.transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.rotation = my_rotation;
        transform.position = player.transform.position + offset;
    }
}
