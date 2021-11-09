using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSortButton : MonoBehaviour
{
    // #region ==================== CLASS VARIABLES ====================

    [Header("References")]
    // All GameObject references
    public GameObject AllEntries;
    public GameObject AllEntries_Selected;
    public GameObject EntriesImages;
    public GameObject EntriesImages_Selected;
    public GameObject Entries3D;
    public GameObject Entries3D_Selected;

    // #endregion



    // #region ==================== SELECT METHODS ====================

    private void Awake()
    {
        Select_AllEntries();
    }

    // #endregion



    // #region ==================== SELECT METHODS ====================

    public void Select_AllEntries()
    {
        UnselectAll();
        AllEntries.SetActive(false);
        AllEntries_Selected.SetActive(true);
    }


    public void Select_EntriesImage()
    {
        UnselectAll();
        EntriesImages.SetActive(false);
        EntriesImages_Selected.SetActive(true);
    }


    public void Select_Entries3D()
    {
        UnselectAll();
        Entries3D.SetActive(false);
        Entries3D_Selected.SetActive(true);
    }


    public void UnselectAll()
    {
        AllEntries.SetActive(true);
        AllEntries_Selected.SetActive(false);

        EntriesImages.SetActive(true);
        EntriesImages_Selected.SetActive(false);

        Entries3D.SetActive(true);
        Entries3D_Selected.SetActive(false);
    }

    // #endregion
}
