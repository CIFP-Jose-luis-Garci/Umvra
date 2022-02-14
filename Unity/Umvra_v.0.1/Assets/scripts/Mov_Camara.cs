using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Camara : MonoBehaviour
{
    [SerializeField] Transform playerPosition;

    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;

    [SerializeField] float offsetY = 3f;


    [SerializeField] bool isFollowing = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            Vector3 targetPosition = new Vector3(playerPosition.position.x, playerPosition.position.y + offsetY, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
        }

        
    }

    public void StopFollowing()
    {
        isFollowing = false;
    }
    public void StartFollowing()
    {
        isFollowing = true;
    }




}
