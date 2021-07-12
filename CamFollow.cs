using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject Car = null;
    public GameObject FollowObject = null;
    public float FollowSpeed = 3.0f;

    private void Update()
    {
        if (FollowObject == null || Car == null)
        {
            return;
        }

        this.transform.LookAt(Car.transform);
        float CameraMoveAmount = Mathf.Abs(Vector3.Distance(this.transform.position, FollowObject.transform.position) * FollowSpeed);
        this.transform.position = Vector3.MoveTowards(this.transform.position, FollowObject.transform.position, CameraMoveAmount * Time.deltaTime);
    }
}