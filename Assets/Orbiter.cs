using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiter : MonoBehaviour
{
    public float radius;
    public float speed;
    public float startingAngle;

    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        angle = startingAngle;
    }

    // Update is called once per frame
    void Update()
    {
        angle += Mathf.Deg2Rad * speed * Time.deltaTime;

        float posX, posY, posZ;
        posX = radius * Mathf.Cos(angle);
        posY = transform.position.y;
        posZ = radius * Mathf.Sin(angle);
        transform.position = new Vector3(posX, posY, posZ);
    }
}
