using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCQShape : MonoBehaviour
{
 /*   public GameObject correctPos;
*/    Vector3 offset;
    private Vector2 originalPos;
/*    public string destinationTag = "DropArea";*/
    private bool dragging, correctAns;
/*    [SerializeField] private SpriteRenderer rendererShape;*/
    private MCQSlot slotShape;
    private Vector3 resetPosition;

    private void Start()
    {
        resetPosition = this.transform.localPosition;
    }
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
/*        transform.GetComponent<Collider2D>().enabled = false;*/
    }

    void OnMouseDrag()
    {
        transform.position = MouseWorldPosition() + offset;
    }

    void OnMouseUp()
    {
        dragging = false;
        originalPos = offset;
/*        transform.GetComponent<Collider2D>().enabled = true;*/

        correctAns = true;
/*        Debug.Log("Correct Ans");*/
    }

    Vector3 MouseWorldPosition()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}


/*        var rayOrigin = Camera.main.transform.position;
        var rayDirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitInfo;
        if (Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
        {
            if (hitInfo.transform.tag == destinationTag)
            {
                transform.position = hitInfo.transform.position;
            }
        }*/

/*        if(Mathf.Abs(this.transform.localPosition.x - correctPos.transform.localPosition.x) < 0.5f &&
            Mathf.Abs(this.transform.localPosition.x - correctPos.transform.localPosition.x) < 0.5f)
        {
            this.transform.localPosition = new Vector3(correctPos.transform.localPosition.x,
                correctPos.transform.localPosition.y, correctPos.transform.localPosition.z);
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }*/