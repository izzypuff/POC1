using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WindowController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public RectTransform titleBar;

    private bool isDragging = false;
    private Vector2 originalMousePosition;
    private Vector3 originalWindowPosition;

    public float dragSpeed = 1.0f;
    public float dragFollowFactor = 0.5f;

    //zposition or layers of windows
    private float selectedZPosition = -1.0f;
    private float defaultZPosition = 0.0f;

    void Start()
    {
    }

    void Update()
    {
        // dragging window stuff
        if (isDragging)
        {
            Vector2 mousePosition = Input.mousePosition;

            // offset for dragging
            Vector3 offset = (Vector3)((mousePosition - originalMousePosition) * dragSpeed * dragFollowFactor);

            //update window
            titleBar.parent.position = originalWindowPosition + offset;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //set as top
        SetAsTopmostWindow();

        //check pointer is on dragging bar
        if (eventData.pointerCurrentRaycast.gameObject == titleBar.gameObject)
        {
            isDragging = true;
            originalMousePosition = eventData.position;
            originalWindowPosition = titleBar.parent.position;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //stop dragging when releasing
        isDragging = false;
    }

    void SetAsTopmostWindow()
    {
        //find all windows with the tag window
        GameObject[] allWindows = GameObject.FindGameObjectsWithTag("Window");

        // Set all windows to their default Z position
        foreach (GameObject window in allWindows)
        {
            if (window != this.gameObject)
            {
                SetWindowZPosition(window, defaultZPosition);
            }
        }

        //setting layer
        SetWindowZPosition(this.gameObject, selectedZPosition);

        //idk i dont think this one works but i dont wanna change lol
        transform.SetAsLastSibling();
    }

    void SetWindowZPosition(GameObject window, float zPosition)
    {
        //update z pos
        Vector3 newPosition = window.transform.position;
        newPosition.z = zPosition;
        window.transform.position = newPosition;
    }

}