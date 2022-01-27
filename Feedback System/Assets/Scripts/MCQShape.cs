using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCQShape : MonoBehaviour
{
    Vector3 offset;
    private Vector2 originalPos;
    private bool dragging, correctAns;
/*    private MCQSlot slotShape;
    private Vector3 resetPosition;*/

/*    private void Start()
    {
        resetPosition = this.transform.localPosition;
    }*/
    private void Awake()
    {
        originalPos = transform.position;
    }
    private void Update()
    {
        if (!dragging) return;
        var mousePosition = MouseWorldPosition();
        transform.position = mousePosition - offset;
    }
    void OnMouseDown()
    {
        dragging = true;
        offset = transform.position - MouseWorldPosition();
    }

    void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }

    void OnMouseUp()
    {
        dragging = false;
        originalPos = offset;
        correctAns = true;
    }

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}