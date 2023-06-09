using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private Transform target;
    public float speed = 70f;
    public GameObject impactEffect;

    public void Seek(Transform _target) {
        target = _target;
    }

    private void Update() {
        if (target == null) {
            Destroy(gameObject);
            return;
        }

        Vector3 direction = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        if (direction.magnitude <= distanceThisFrame) {
            HitTarget();
            return;
        }
        transform.Translate(direction.normalized*distanceThisFrame, Space.World);
    }

    private void HitTarget() {
        GameObject effectIns = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
