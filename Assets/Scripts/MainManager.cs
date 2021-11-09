using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // #region ==================== CLASS VARIABLES ====================

    [Header("References")]
    public static MainManager Instance;         // Singleton reference
    public GameObject Prefab_EntryImage;
    public GameObject Prefab_Entry3D;

    // #endregion



    // #region ==================== INIT METHODS ====================

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    // #endregion



    // #region ==================== GALLERY METHODS ====================

    public void CreateEntryImage()
    {
        Instantiate(Prefab_EntryImage, new Vector3(0, 0, 0), Quaternion.identity);
    }


    public void CreateEntry3D()
    {
        Instantiate(Prefab_Entry3D, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // #endregion
}
