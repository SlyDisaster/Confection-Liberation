using UnityEngine;

public class MovingZombie : MonoBehaviour
{

    [SerializeField] float distanceToCover;
    [SerializeField] float speed;

    private Vector3 startingPosition;

     void Start()
    {
        startingPosition = transform.position;
        speed = Random.Range(1, 10);
    }

    void Update()
    {

        Vector3 v = startingPosition;
        v.z += distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}