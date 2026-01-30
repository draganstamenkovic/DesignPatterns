using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DesignPatternManager : MonoBehaviour
{
    [SerializeField] private Button prototypeButton;
    [SerializeField] private Button factoryMethodButton;
    [SerializeField] private Button objectPoolButton;
    [SerializeField] private Button builderButton;
    
    [SerializeField] private Button commandButton;
    [SerializeField] private Button stateButton;

    private void OnEnable()
    {
        prototypeButton.onClick.AddListener(OnPrototypeButtonClicked);
        factoryMethodButton.onClick.AddListener(OnFactoryMethodButtonClicked);
        objectPoolButton.onClick.AddListener(OnObjectPoolButtonClicked);
        builderButton.onClick.AddListener(OnBuilderButtonClicked);
        
        commandButton.onClick.AddListener(OnCommandButtonClicked);
        stateButton.onClick.AddListener(OnStateButtonClicked);
    }

    private void OnDisable()
    {
        prototypeButton.onClick.RemoveListener(OnPrototypeButtonClicked);
        factoryMethodButton.onClick.RemoveListener(OnFactoryMethodButtonClicked);
        objectPoolButton.onClick.RemoveListener(OnObjectPoolButtonClicked);
        builderButton.onClick.RemoveListener(OnBuilderButtonClicked);
        
        commandButton.onClick.RemoveListener(OnCommandButtonClicked);
        stateButton.onClick.RemoveListener(OnStateButtonClicked);
    }
    private void OnPrototypeButtonClicked()
    {
        SceneManager.LoadScene("PrototypePattern");
    }

    private void OnFactoryMethodButtonClicked()
    {
        SceneManager.LoadScene("FactoryMethodPattern");
    }

    private void OnObjectPoolButtonClicked()
    {
        SceneManager.LoadScene("ObjectPoolPattern");
    }

    private void OnBuilderButtonClicked()
    {
        SceneManager.LoadScene("BuilderPattern");
    }

    private void OnCommandButtonClicked()
    {
        SceneManager.LoadScene("CommandPattern");
    }

    private void OnStateButtonClicked()
    {
        SceneManager.LoadScene("StatePattern");
    }
}
