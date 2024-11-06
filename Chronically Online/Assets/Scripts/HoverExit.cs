using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverExit : MonoBehaviour, IPointerExitHandler
{
    private Animator anim;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        anim.Play("Close");
    }
}
