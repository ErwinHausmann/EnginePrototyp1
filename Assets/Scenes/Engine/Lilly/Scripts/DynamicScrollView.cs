using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicScrollView : MonoBehaviour
{
    [SerializeField] private Transform scrollViewContent;

    [SerializeField] private GameObject prefab;

    [SerializeField] private List<Sprite> spaceShips;

    private void Start()
    {
        foreach (Sprite spaceShip in spaceShips)
        {
            GameObject newSpaceShip = Instantiate(prefab, scrollViewContent);
            if (newSpaceShip.TryGetComponent<ScrollViewItem>(out ScrollViewItem item))
            {
                item.ChangeImage(spaceShip);
            }
        }
    }
}

