using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reference : MonoBehaviour
{
    public GameObject TheObjectThatIWantToRef;
    public bool TrueLeftRightFallsUpDown;

    public Vector3 scale;
    private Vector3 offset;
    private float timer;
    private float startTimer;
    // Start is called before the first frame update
    void Start()
    {
        offset = TheObjectThatIWantToRef.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        startTimer = Time.deltaTime;

        if (startTimer >= 0)
        {
            timer += Time.deltaTime;
        }

        if (TrueLeftRightFallsUpDown)
        {
            TheObjectThatIWantToRef.transform.position = new Vector3(Mathf.Sin(timer), 0, 0) + offset;
        }
        else
        {
            TheObjectThatIWantToRef.transform.position = new Vector3(0, Mathf.Sin(timer), 0) + offset;
        }
    }
}
