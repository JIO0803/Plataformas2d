using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas1 : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;
    private Transform _targetWaypoint;
    private int _currentWaypointIndex = 0;

    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Plataformas1>().enabled = false;
        _targetWaypoint = _waypoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            _targetWaypoint.position,
            _speed * Time.deltaTime
            );
    }
}
