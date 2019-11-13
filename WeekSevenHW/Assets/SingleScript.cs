using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleScript : MonoBehaviour
{
    public GameObject TheObjectThatIWantToRef;
    public bool IfActiveDoAction;
    public Light lightColorChange;

    private Vector3 offset;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        offset = TheObjectThatIWantToRef.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       
        if (IfActiveDoAction)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                TheObjectThatIWantToRef.transform.position = new Vector3(Mathf.Sin(timer) , Mathf.Cos(timer + 2 ), 0) + offset;
            }
            if (Input.GetKey(KeyCode.Q))
            {
                TheObjectThatIWantToRef.transform.position = new Vector3(Mathf.Cos(timer + 10), Mathf.Tan(timer + 10), 0) + offset;
            }
           
        }
        else
        {
            if (Input.GetKey(KeyCode.Space))
            {
                TheObjectThatIWantToRef.transform.position = new Vector3(0, Mathf.Sin(timer), Mathf.Sin(timer)+ 3) + offset;
            }
        }

        float AnyColor = Mathf.Sin(timer) / 2 + .5f;
        float NewColor = Mathf.Cos(timer) / 2 + .5f;

            if (Input.GetKey(KeyCode.V))
            {
                lightColorChange.color = new Color(255, AnyColor, 0);
            }
            if (Input.GetKey(KeyCode.C))
            {
                lightColorChange.color = new Color(AnyColor, 255, 0);
            }
            if (Input.GetKey(KeyCode.B))
            {
                lightColorChange.color = new Color(0, 0, NewColor + .1f);
            }
    }
}
