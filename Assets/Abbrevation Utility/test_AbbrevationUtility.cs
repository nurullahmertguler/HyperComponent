using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test_AbbrevationUtility : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI testText;

    private void Start()
    {
        testText.text = "123000 is " + AbbrevationUtility.AbbreviateNumber(123000) + "\n" +
                        "456000000 is " + AbbrevationUtility.AbbreviateNumber(456000000) + "\n" +
                        "789000000000 is " + AbbrevationUtility.AbbreviateNumber(789000000000) + "\n" +
                        "135000000000000 is " + AbbrevationUtility.AbbreviateNumber(135000000000000);
    }
}
