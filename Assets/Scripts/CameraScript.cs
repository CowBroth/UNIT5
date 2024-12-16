using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Vector3[] targetPos;

    public Vector3 mPos;
    public Vector3 vel = Vector3.zero;
    Quaternion a;
    Quaternion b;
    private float t = 0.01f;
    public float goTo = 0;
    float goTime = 0.2f;

    float screenWidth;
    float screenHeight;
    float mouseX;
    float mouseY;

    private void Start()
    {
        targetPos = new Vector3[]{new Vector3(0, 1, -10), new Vector3(-2, -0.5f, -2.4f), new Vector3(1.9f, -1.2f, -5)};
        screenWidth = Screen.width;
        screenHeight = Screen.height;
    }

    void Update()
    {
        mPos = Input.mousePosition;

        mouseX = mPos.x;
        mouseY = mPos.y;
        if( mouseX < 0 )
        {
            mouseX = 0;
        }
        if( mouseX > screenWidth )
        {
            mouseX = screenWidth;   
        }
        if( mouseY < 0 )
        {
            mouseY = 0;
        }
        if( mouseY > screenHeight )
        {
            mouseY = screenHeight;   
        }
        mouseX = (mouseX / screenWidth) - 0.5f;
        mouseY = (mouseY / screenHeight) - 0.5f;

        b = Quaternion.Euler(mouseY * -6f, mouseX * 8, 0);
        
        transform.rotation = Quaternion.Slerp(a, b, t);
        a = transform.rotation;

        if (goTo == 0)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPos[0], ref vel, goTime);
        }
        if (goTo == 1)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPos[1], ref vel, goTime);
        }
        if (goTo == 2)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPos[2], ref vel, goTime);
        }
    }
    public void ButtonVar(int q)
    {
        goTo = q;
    }
}