using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private Music _press;
    [SerializeField] private Warning _warning;
    [SerializeField] private GameObject _spinButton;
    [SerializeField] private GameObject _shopButton;
    [SerializeField] private GameObject _closeWheelFortuneButton;
    [SerializeField] private GameObject _closeShop;
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _wheelFortune;
    [SerializeField] private GameObject _shop;
    [SerializeField] private GameObject _cursor;
    [SerializeField] private GameObject _boubleArrow;
    [SerializeField] private GameObject _textMove;
    [SerializeField] private GameObject _imageandtextCoin;
    [SerializeField] private GameObject _coins;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenMenu();
        }
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void OpenWheelFortune()
    {
        _press.PlayMusic();
        _cursor.SetActive(false);
        _boubleArrow.SetActive(false);
        _textMove.SetActive(false);
        _shopButton.SetActive(false);
        _spinButton.SetActive(false);
        _wheelFortune.SetActive(true);
        _closeWheelFortuneButton.SetActive(true);
    }

    public void CloseWheelFortune()
    {
        _press.PlayMusic();
        _cursor.SetActive(true);
        _boubleArrow.SetActive(true);
        _textMove.SetActive(true);
        _shopButton.SetActive(true);
        _spinButton.SetActive(true);
        _wheelFortune.SetActive(false);
        _closeWheelFortuneButton.SetActive(false);
        _imageandtextCoin.SetActive(false);
        _coins.SetActive(false);
    }

    public void OpenShop()
    {
        _press.PlayMusic();
        _cursor.SetActive(false);
        _boubleArrow.SetActive(false);
        _textMove.SetActive(false);
        _shopButton.SetActive(false);
        _spinButton.SetActive(false);
        _shop.SetActive(true);
        _closeShop.SetActive(true);
    }

    public void CloseShop()
    {
        _press.PlayMusic();
        _cursor.SetActive(true);
        _boubleArrow.SetActive(true);
        _textMove.SetActive(true);
        _shopButton.SetActive(true);
        _spinButton.SetActive(true);
        _shop.SetActive(false);
        _closeShop.SetActive(false);
    }

    public void OpenMenu()
    {
        _press.PlayMusic();
        Time.timeScale = 0;
        _menu.SetActive(true);
    }

    public void CloseMenu()
    {
        _press.PlayMusic();
        _menu.SetActive(false);
        Time.timeScale = 1;
    }
    public void ReturnMenu()
    {
        _press.PlayMusic();
        _warning.ReturnMainAppear();
    }

    public void PressYesReturnMenu()
    {
        _press.PlayMusic();
        SceneManager.LoadScene(0);
    }

    public void PressYesExit()
    {
        _press.PlayMusic();
        Application.Quit();
    }

    public void PressNo()
    {
        _press.PlayMusic();
        _warning.Disappear();
    }

    public void Exit()
    {
        _press.PlayMusic();
        _warning.ExitAppear();
    }
}