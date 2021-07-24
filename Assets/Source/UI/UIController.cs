using System.Collections;
using System.Collections.Generic;
using Controllers;
using Controllers.States;
using UnityEngine;

public class UIController : MonoBehaviour
{
    private PlayerController _playerController;
    
    public void Initialize(PlayerController playerController)
    {
        _playerController = playerController;
    }
    
    public void Build1x1Mode()
    {
        _playerController.SetState(PlayerMode.Build1x1);
    }
    
    public void Build2x2Mode()
    {
        _playerController.SetState(PlayerMode.Build2x2);
    }
    
    public void DeleteMode()
    {
        _playerController.SetState(PlayerMode.Remove);
    }
}
