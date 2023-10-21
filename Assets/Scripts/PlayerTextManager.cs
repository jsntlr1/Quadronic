using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTextManager : MonoBehaviour
{
    public TextMeshProUGUI levelText; 
    public TextMeshProUGUI nameText;  
    public PlayerStats player;

    void Start()
    {
       
    }

    void Update()
    {
        levelText.text = "Level " + player.level.ToString();
        nameText.text = player.name;
    }
}