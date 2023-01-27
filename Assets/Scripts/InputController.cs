using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputController : MonoBehaviour
{
    [SerializeField] TMP_InputField velocityInput;
    [SerializeField] TMP_InputField angleInput;
    [SerializeField] Button shootButton;
    [SerializeField] PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        if (shootButton)
        {
            shootButton.onClick.AddListener(() => ShootButtonOnClick());
        }
    }

    void ShootButtonOnClick()
    {
        float initialVelocity = 0;
        float angle = 0;

        if (float.TryParse(velocityInput.text, out initialVelocity) && float.TryParse(angleInput.text, out angle))
        {
            playerController.Shoot(initialVelocity, angle);
        }
    }
}
