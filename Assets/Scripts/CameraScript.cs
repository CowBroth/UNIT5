using UnityEngine;

public class CameraScript : MonoBehaviour
{
    float zA;
    public float div;
    void Update()
    {
        div = -500 / -Input.mousePosition.x;
        zA = Input.mousePosition.x / div;
        transform.position = new Vector3(div, 1, -10);
        print(Input.mousePosition);
    }
}
