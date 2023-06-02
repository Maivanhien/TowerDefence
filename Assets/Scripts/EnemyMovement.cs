using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    [SerializeField] private float speed = 10f;
    private Transform target;
    private int wayPointIndex;

    private void Start() {
        wayPointIndex = 0;
        target = WayPoints.points[wayPointIndex];
    }

    private void Update() {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, target.position) <= 0.2f) {
            SetNextWayPointIndex();
        }
    }

    private void SetNextWayPointIndex() {
        wayPointIndex++;
        if (wayPointIndex >= WayPoints.points.Length) {
            Destroy(gameObject);
        }
        target = WayPoints.points[wayPointIndex % WayPoints.points.Length];
    }
}
