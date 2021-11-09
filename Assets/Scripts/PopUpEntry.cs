using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpEntry : MonoBehaviour
{
    // #region ==================== CLASS VARIABLES ====================

    [Header("References")]
    public Text InputText;                          // Reference to Text component into the input field

    [Header("Variables")]
    private string fileName;                        // File name entered into the input field
    [SerializeField] private bool isEntryImage;     // Defines whether or not this script is for creating EntryImage or not (Entry3D otherwise)

    // #endregion



    // #region ==================== BUTTONS METHODS ====================

    public void Exit()
    {
        InputText.text = "";
        fileName = "";
        this.gameObject.SetActive(false);
    }

    public void Validate()
    {
        // If the input field is not empty
        if (InputText.text != "")
        {
            // Set file name to input text value
            fileName = InputText.text;

            // If it is an image, then create an EntryImage object
            if (isEntryImage)
            {
                MainManager.Instance.CreateEntryImage(fileName);
            }
            // Otherwise, create an Entry3D object
            else
            {
                MainManager.Instance.CreateEntry3D(fileName);
            }

            Exit();
        }
    }

    // #endregion



    // #region ====================  METHODS ====================
}
