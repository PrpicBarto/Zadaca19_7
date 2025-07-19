using TMPro;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] TMP_Text doorText;
    bool canOpen;
    bool isOpen;
    bool isHere;

    private void Update()
    {
        if (isHere && canOpen && !isOpen && Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(0, -90, 0);
            isOpen = true;
        }
        else if (isHere && canOpen && isOpen && Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(0, 90, 0);
            isOpen = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
        {
            doorText.gameObject.SetActive(true);
            isHere = true;
            if (playerMovement.hasKey)
            {
                canOpen = true;
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
        {
            doorText.gameObject.SetActive(false);
            isHere = false;
        }
    }
}
