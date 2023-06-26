using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class ScrollItem : MonoBehaviour
{
    [SerializeField]
    private Image childImage;

    public void ChangeImage(Sprite image){
        childImage.sprite = image;
    }
}
