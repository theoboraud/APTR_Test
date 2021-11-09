using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpDelete : MonoBehaviour
{
    // #region ==================== CLASS VARIABLES ====================

    [Header("Variables")]
    [System.NonSerialized] public GameObject EntryToDelete;

    // #endregion



    // #region ==================== DELETE METHODS ====================

    public void Validate()
    {
        MainManager.Instance.Delete(EntryToDelete);
        Exit();
    }

    public void Exit()
    {
        EntryToDelete = null;
        this.gameObject.SetActive(false);
    }

    // #endregion
}
