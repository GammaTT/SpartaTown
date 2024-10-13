using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform followTarget;

    private Transform myTransform;

    private void Awake()
    {
        myTransform = transform;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = followTarget.position;

        Vector3 pos = new Vector3 (targetPos.x, targetPos.y, myTransform.position.z);

        myTransform.position = pos;
    }
}
