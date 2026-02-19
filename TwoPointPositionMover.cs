using UnityEngine;

public class TwoPointPositionMover : MonoBehaviour
{
    public Route2PointPosSO route;
    public float speed = 2f;

    private Vector3 target;

    void Start()

    {
        transform.position = route.PointA;
        target = route.PointB;
    }

    void Update()

    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position == target)
        {
            target = (target == route.PointA) ? route.PointB : route.PointA;
        }
    }
}
