using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAim : MonoBehaviour
{

    Animator animator;

    [SerializeField] Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Robot").transform;


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = player.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

}
