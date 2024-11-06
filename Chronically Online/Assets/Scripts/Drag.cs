using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;

    //z sorting
    private float selectedZPos = -1.0f;
    private float defaultZPos = 0.0f;

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
            pointerData.position,
            canvas.worldCamera,
            out position);

        transform.position = canvas.transform.TransformPoint(position);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SetAsTopWindow();
    }

    void SetAsTopWindow()
    {
        GameObject[] allPages = GameObject.FindGameObjectsWithTag("Page");

        foreach (GameObject page in allPages)
        {
            if (page != this.gameObject)
            {
                SetWindowZPosition(page, defaultZPos);
            }
        }

        //set layer
        SetWindowZPosition(this.gameObject, selectedZPos);

    }

    void SetWindowZPosition(GameObject page, float zPosition)
    {
        Vector3 newPosition = page.transform.position;
        newPosition.z = zPosition;
        page.transform.position = newPosition;
    }
}
