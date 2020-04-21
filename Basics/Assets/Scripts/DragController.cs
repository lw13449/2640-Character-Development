using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;


public class DragController : MonoBehaviour
{
    private Vector3 offsetLocation;
    private Vector3 newLocation;
    private Camera camera;

    private bool CanDrag { get; set; }
    public UnityEvent onDrag, onUp;
    public bool Draggable { get; set; }

    private void Start()
    {
        camera = Camera.main;
        Draggable = true;
    }

    public IEnumerator OnMouseDown()
    {
        onDrag.Invoke();
        offsetLocation = transform.position - camera.ScreenToWorldPoint(Input.mousePosition);
        yield return new WaitForFixedUpdate();
        CanDrag = true;
        while (CanDrag)
        {
            yield return new WaitForFixedUpdate();
            newLocation = camera.ScreenToWorldPoint(Input.mousePosition) + offsetLocation;
            transform.position = newLocation;
        }
    }

    private void OnMouseUp()
    {
        CanDrag = false;
        if (Draggable)
        {
            onUp.Invoke();
        }
    }
}