using UnityEngine;

public class MouseMove : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        if (Input.GetMouseButton(0))
        {
            float y = transform.position.y;
            transform.position = GetMouseAsWorldPoint() + mOffset;
            transform.position = new Vector3(transform.position.x, y, transform.position.z);

        }
    }
    private void Update()
    {
        OnMouseDrag();
        OnMouseDown();
        GetMouseAsWorldPoint();
    }
}