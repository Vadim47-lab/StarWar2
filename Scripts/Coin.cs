using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private TMP_Text _textCountCoins;
    [SerializeField] private GameObject _imageandtextCoin;
    [SerializeField] private WheelFortune _wheelFortune;

    private int _countCoins;
    private float _secondsShowCoins;
    private float _gameSeconds;
    private bool _stopGetCoins;

    private void Start()
    {
        _stopGetCoins = false;
        _secondsShowCoins = 3;
    }

    private void Update()
    {
        if(_stopGetCoins == true)
        {
            _gameSeconds = _gameSeconds + Time.deltaTime + .0f;

            if (_gameSeconds >= _secondsShowCoins)
            {
                _imageandtextCoin.SetActive(false);
                ShowCoins();
            }
        }
    }

    private void OnEnable()
    {
        _wheelFortune.CoinsChanged += OnCoinsChanged;
    }

    private void OnDisable()
    {
        _wheelFortune.CoinsChanged -= OnCoinsChanged;
    }

    private void OnCoinsChanged(int _prize)
    {
        _stopGetCoins = true;
        _countCoins += _prize;
    }

    private void ShowCoins()
    {
        _textCountCoins.text = "" + _countCoins;
        _stopGetCoins = false;
        _gameSeconds = 0;
    }
}