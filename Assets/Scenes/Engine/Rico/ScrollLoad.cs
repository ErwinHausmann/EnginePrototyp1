using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollLoad : MonoBehaviour
{
    [SerializeField]
    private Transform scrollViewContent;

    [SerializeField]
    private GameObject prefab;

    [SerializeField]
    private List<Sprite> spaceShips;

    private void Start(){
        foreach (Sprite spaceShip in spaceShips)
        {
            GameObject newSpaceShip = Instantiate(prefab, scrollViewContent);
            if (newSpaceShip.TryGetComponent<ScrollItem>(out ScrollItem item)){
                item.ChangeImage(spaceShip);
            }
        }
    }
}
