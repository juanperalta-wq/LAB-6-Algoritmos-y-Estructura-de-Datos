using Sirenix.OdinInspector;
using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIGameManager : MonoBehaviour
{
    public InputSystem_Actions inputs;
    public WindowManager wmanager = new();

    private void Awake()
    {
        inputs = new();
    }


    private void OnEnable()
    {
        inputs.Enable();
        inputs.UI.Escape.performed += HideCurrentPanel;

        wmanager.OnElementAdded += OnElementAdded;
        wmanager.OnElementRemoved += OnElementRemoved;
    }


    void Start()
    {

    }
    void Update()
    {

    }
    private void OnElementAdded(Window window)
    {
        window.window.SetActive(true);

        // Traer al frente la ventana actual (mueve al final de la jerarquía)
        window.window.transform.SetAsLastSibling();
    }
    private void OnElementRemoved(Window window)
    {
        window.window.SetActive(false);
        //->desactivo el panel y lo mando al final
    }

    private void HideCurrentPanel(InputAction.CallbackContext context)
    {
        if (wmanager.Count == 0) return;

        if (!wmanager.Peek().window.activeSelf)
        {
            wmanager.Pop();
            HideCurrentPanel(context);
        }
        else
        {
            wmanager.Pop();
            Debug.Log("Escape");
        }
    }

    public void BtnOpenPanel(GameObject panel)
    {
        Window window = new(panel);
        wmanager.Push(window);
    }
    [Button]
    public void PeekFromStack()
    {
        Debug.Log(wmanager.Peek().window.name);
    }
    [Button]
    public void Count() => Debug.Log(wmanager.Count);

}