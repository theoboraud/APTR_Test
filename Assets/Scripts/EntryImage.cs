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
    public Text Text_Title;
    public Text Text_Type;
    public GameObject GO_ButtonDelete;

    [Header("Variables")]
    private Image image;

    // #endregion



    // #region ==================== INIT METHODS ====================

    private void Awake()
    {
        GO_Image.GetComponent<Image>().sprite = RandomImage();
        GO_ButtonDelete.SetActive(false);
    }

    // #endregion



    // #region ==================== IMAGE METHODS ====================

    private Sprite RandomImage()
    {
        int _randIndex = Random.Range(0, Images.Count);
        return Images[_randIndex];
    }

    // #endregion



    // #region ==================== DELETE METHODS ====================

    public void DeleteButton(bool _bool)
    {
        GO_ButtonDelete.SetActive(_bool);
    }


    public void Delete()
    {
        MainManager.Instance.Enable_PopUpDelete(this.gameObject);
    }

    // #endregion
}
