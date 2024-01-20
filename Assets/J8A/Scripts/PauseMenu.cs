using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _playerCapsule;
    private PlayerInput _playerInput;
    [SerializeField] private List<GameObject> toggleUIObjects;

    public static bool gamePaused;
    private InputAction pausedAction;

    private void OnEnable()
    {
        if (_playerCapsule != null)
        {
            _playerInput = _playerCapsule.GetComponent<PlayerInput>();
        }
        
        pausedAction = _playerInput.actions["Pause"];
        
        Time.timeScale = 1.0f;
        gamePaused = false;
        PauseUI();
    }

    private void Update()
    {
        Pause();
    }

    private void Pause()
    {
        if (pausedAction.WasPerformedThisFrame())
        {
            gamePaused = !gamePaused;
            if (gamePaused)
            {
                Time.timeScale = 0.0f;
                PauseUI();
            }
            else
            {
                Time.timeScale = 1.0f;
                PauseUI();
            }
        }
    }

    private void PauseUI()
    {
        //If gamePaused = true, turn them on
        foreach (GameObject obj in toggleUIObjects)
        {
            obj.SetActive(gamePaused);
        }
    }

    public void ActivateTimeScale()
    {
        Time.timeScale = 1.0f;
    }
}
