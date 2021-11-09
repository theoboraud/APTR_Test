using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEntry : MonoBehaviour
{
    // #region ==================== CLASS VARIABLES ====================

    [Header("References")]
    public GameObject PopUp_AddEntry;      // Pop up enabled to add a new image to the gallery

    // #endregion



    // #region ==================== BUTTONS METHODS ====================

    public void Open_AddEntry()
    {
        MainManager.Instance.DeleteEntry.Unselect();
        PopUp_AddEntry.SetActive(true);
    }

    // #endregion
}
