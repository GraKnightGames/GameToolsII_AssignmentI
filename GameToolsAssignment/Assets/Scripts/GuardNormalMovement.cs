using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardNormalMovement : MonoBehaviour
{
    public Transform[] wayPoints;
    [SerializeField] private float waitTime;
    private float startingWaitTime;
    private int randomSpot;
    [SerializeField] private float speed;
    // Use this for initialization
    void Start()
    {
        startingWaitTime = waitTime;
        randomSpot = Random.Range(0, wayPoints.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[randomSpot].position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, wayPoints[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, wayPoints.Length);
            }
            else if (waitTime < 0)
            {
                waitTime = startingWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
