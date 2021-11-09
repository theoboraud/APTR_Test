using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteEntry : MonoBehaviour
{
    // #region ==================== CLASS VARIABLES ====================

    [Header("References")]
    public GameObject Text_DeleteEntry;
    public GameObject Sprite_DeleteEntry;
    public GameObject Text_DeleteEntry_Selected;
    public GameObject Sprite_DeleteEntry_Selected;

    // #endregion



    // #region ==================== BUTTONS METHODS ====================

    public void Select()
    {
        Text_DeleteEntry.SetActive(false);
        Sprite_DeleteEntry.SetActive(false);
        Text_DeleteEntry_Selected.SetActive(true);
        Sprite_DeleteEntry_Selected.SetActive(true);

        MainManager.Instance.EnterDeleteMode();
    }


    public void Unselect()
    {
        Text_DeleteEntry.SetActive(true);
        Sprite_DeleteEntry.SetActive(true);
        Text_DeleteEntry_Selected.SetActive(false);
        Sprite_DeleteEntry_Selected.SetActive(false);

        MainManager.Instance.QuitDeleteMode();
    }

    // #endregion
}
