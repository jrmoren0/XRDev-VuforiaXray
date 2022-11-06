using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrganSelector : MonoBehaviour
{
    [SerializeField] private Image brain, heart, leftLung, rightLung;

   public void OnBrainFound()
    {
        brain.color = new Color(1, 1, 1,1);
    }
    public void OnHeartFound()
    {
        heart.color = new Color(1, 1, 1, 1);
    }

    public void OnLeftLungFound()
    {
        leftLung.color = new Color(1, 1, 1, 1);
    }

    public void OnRightLungFound()
    {
        rightLung.color = new Color(1, 1, 1, 1);
    }
}
