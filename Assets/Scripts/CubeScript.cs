using UnityEngine;

public class CubeScript : MonoBehaviour
{
    Vector3[] targetPos;

    public Vector3 mPos;
    public Vector3 vel = Vector3.zero;
    Quaternion a;
    Quaternion b;
    private float t = 0.01f;
    public float testX = 1;
    public float testY = 1;

    float screenWidth;
    float screenHeight;
    float mouseX;
    float mouseY;

    private void Start()
    {
        screenWidth = Screen.width;
        screenHeight = Screen.height;
    }

    void Update()
    {
        mPos = Input.mousePosition;

        mouseX = mPos.x;
        mouseY = mPos.y;
        if (mouseX < 0)
        {
            mouseX = 0;
        }
        if (mouseX > screenWidth)
        {
            mouseX = screenWidth;
        }
        if (mouseY < 0)
        {
            mouseY = 0;
        }
        if (mouseY > screenHeight)
        {
            mouseY = screenHeight;
        }
        mouseX = (mouseX / screenWidth) - 0.5f;
        mouseY = (mouseY / screenHeight) - 0.5f;

        b = Quaternion.Euler(mouseY * testY, mouseX * testX, 0);

        transform.rotation = Quaternion.Slerp(a, b, t);
        a = transform.rotation;
    }
}