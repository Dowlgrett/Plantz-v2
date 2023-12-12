using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropGhoster : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{

    private GameObject _ghostImage;
    public void OnBeginDrag(PointerEventData eventData)
    {
        _ghostImage = new GameObject();
        var spriteRenderer = _ghostImage.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = GetComponent<Card>().CardInfo.CardSprite;
        spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0.5f);
        spriteRenderer.sortingOrder = 2;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(eventData.position);
        position.z = 0f;
        _ghostImage.transform.position = position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Destroy(_ghostImage.gameObject);
    }
}
