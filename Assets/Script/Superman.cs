using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Superman : MonoBehaviour
{
    private GameObject target;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * 10);
        }
    }

    public void Move(GameObject obj)
    {
        Vector3 rection = obj.transform.position - transform.position;
        float targetAngle = Mathf.Atan2(rection.y, rection.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, targetAngle);
        target = obj;
    }
}
