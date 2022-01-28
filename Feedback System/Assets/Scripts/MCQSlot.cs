using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class MCQSlot : MonoBehaviour
{
    public Image winImage;
    public TextMeshProUGUI winText;
    private Vector3 cubePos;

    private void Start()
    {
        winImage.gameObject.SetActive(false);
        cubePos = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cyliner"))
        {
            winText.text = "Correct Answer";
            winImage.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
            other.gameObject.SetActive(false);
        }
        else
        {
            winText.text = "Wrong Answer";
            winImage.gameObject.SetActive(true);
            transform.position = cubePos;
            Debug.Log("Wrong Anser");
        }
    }

}
