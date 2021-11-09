using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntryImage : MonoBehaviour
{
    // #region ==================== CLASS VARIABLES ====================

    [Header("References")]
    public List<Sprite> Images = new List<Sprite>();
    public GameObject GO_Image;

    [Header("Variables")]
    private Image image;

    // #endregion



    // #region ==================== INIT METHODS ====================

    private void Awake()
    {
        GO_Image.GetComponent<Image>().sprite = RandomImage();
    }

    // #endregion



    // #region #region ==================== IMAGE METHODS ====================

    private Sprite RandomImage()
    {
        int _randIndex = Random.Range(0, Images.Count);
        return Images[_randIndex];
    }

    // #endregion
}
