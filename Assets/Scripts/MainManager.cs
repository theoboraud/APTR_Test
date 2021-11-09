using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // #region ==================== CLASS VARIABLES ====================

    [Header("References")]
    public static MainManager Instance;                                     // Singleton reference
    public GameObject Prefab_EntryImage;                                    // Entry image prefab reference
    public GameObject Prefab_Entry3D;                                       // Entry 3D prefab reference
    public GameObject GalleryImageHolder;                                   // Parent game object of all spawned gallery image entries
    public GameObject Gallery3DHolder;                                      // Parent game object of all spawned gallery 3D entries
    public List<GameObject> GalleryPositions = new List<GameObject>();      // Reference to all possible gallery positions

    [Header("Variables")]
    private List<GameObject> AllEntries = new List<GameObject>();           // Contains all entries, images and 3D
    private List<GameObject> EntriesImage = new List<GameObject>();         // Contains all image entries
    private List<GameObject> Entries3D = new List<GameObject>();            // Contains all 3D entries
    private int maxEntries;                                                 // Max number of entries

    // Enum values for entry sorting
    public enum Sorting
    {
        All,
        Images,
        Models
    }

    private Sorting sortValue = Sorting.All;                                // Contains the value of entry sorting

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

        // Set max number of entries to number of gallery positions
        maxEntries = GalleryPositions.Count;
    }

    // #endregion



    // #region ==================== GALLERY METHODS ====================

    public void CreateEntryImage()
    {
        // Don't create a new entry if reached max number of entries
        if (AllEntries.Count < maxEntries)
        {
            // Instantiate and move to gallery holder images
            GameObject _newEntry = Instantiate(Prefab_EntryImage, new Vector3(0, 0, 0), Quaternion.identity);
            _newEntry.transform.parent = GalleryImageHolder.transform;

            // Add the reference to the lists
            AllEntries.Add(_newEntry);
            EntriesImage.Add(_newEntry);

            // Move the new entry to a gallery position
            SortEntries(sortValue);
        }
    }

    public void CreateEntry3D()
    {
        // Don't create a new entry if reached max number of entries
        if (AllEntries.Count < maxEntries)
        {
            // Instantiate and move to a gallery holder 3D
            GameObject _newEntry = Instantiate(Prefab_Entry3D, new Vector3(0, 0, 0), Quaternion.identity);
            _newEntry.transform.parent = Gallery3DHolder.transform;

            // Add the reference to the lists
            AllEntries.Add(_newEntry);
            Entries3D.Add(_newEntry);

            // Move the new entry to a gallery position
            SortEntries(sortValue);
        }
    }

    public void SortEntries(Sorting _sortValue)
    {
        sortValue = _sortValue;
        switch (sortValue)
        {
            case Sorting.All:
                Sort(AllEntries);
                break;
            case Sorting.Images:
                Sort(EntriesImage);
                Disable(Entries3D);
                break;
            case Sorting.Models:
                Sort(Entries3D);
                Disable(EntriesImage);
                break;
            default:
                break;
        }
    }

    private void Sort(List<GameObject> _sortList)
    {
        for (int i = 0; i < _sortList.Count; i++)
        {
            _sortList[i].SetActive(true);
            _sortList[i].transform.position = GalleryPositions[i].transform.position;
        }
    }

    private void Disable(List<GameObject> _disableList)
    {
        for (int i = 0; i < _disableList.Count; i++)
        {
            _disableList[i].SetActive(false);
        }
    }

    // #endregion
}
