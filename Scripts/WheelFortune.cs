using TMPro;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class WheelFortune : MonoBehaviour
{
    [SerializeField] private TMP_Text _textCoins;
    [SerializeField] private GameObject _imageandtextCoin;
    [SerializeField] private GameObject _coins;
    [SerializeField] private GameObject _fonAds;
    [SerializeField] private GameObject _ads1;
    [SerializeField] private GameObject _ads2;
    [SerializeField] private GameObject _ads3;
    [SerializeField] private Coin _coin;

    public event UnityAction<int> CoinsChanged;

    private Animator _animator;
    private readonly string[] _animationWheelNumber = {"_2500�oins", "_first1000�oins", "_first1500�oins", "_first2000�oins",
    "_fourth1500�oins", "_second1000�oins", "_second1500�oins", "_second2000coins", "_third1500�oins", "_third2000�oins"};
    private readonly int[] _positionAnimation = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private int _randomAnimation;
    private int _randomAds;
    private int _prize;
    private readonly float _secondsGetCoins = 5;
    private float _gameSeconds;
    private bool _startAnimation; 
    private bool _blockButtonSpin;

    private void OnEnable()
    {
        _coin.ButtonSpinChanged += UnlockButtonSpin;
    }

    private void OnDisable()
    {
        _coin.ButtonSpinChanged -= UnlockButtonSpin;
    }

    private void Start()
    {
        _blockButtonSpin = false;
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_startAnimation == true)
        {
            _gameSeconds = _gameSeconds + Time.deltaTime + .0f;

            if (_gameSeconds >= _secondsGetCoins)
            {
                _startAnimation = false;
                _gameSeconds = 0;
                _coins.SetActive(true);
                _imageandtextCoin.SetActive(true);
                _textCoins.text = "" + _prize;

                CoinsChanged?.Invoke(_prize);
            }
        }
    }

    public void WatchAds()
    {
        _fonAds.SetActive(true);
        _randomAds = Random.Range(0, 2);
        switch (_randomAds)
        {
            case 0:
                _ads1.SetActive(true);
                break;
            case 1:
                _ads2.SetActive(true);
                break;
            case 2:
                _ads3.SetActive(true);
                break;
        }
    }

    public void SpinWheelFortune()
    {
        if (_blockButtonSpin == false)
        {
            _imageandtextCoin.SetActive(false);
            _coins.SetActive(false);
            _startAnimation = false;
            _blockButtonSpin = true;
            _randomAnimation = Random.Range(0, 9);

            for (int i = 0; i < _animationWheelNumber.Length; i++)
            {
                if (_randomAnimation == i)
                {
                    _startAnimation = true;
                    _animator.SetBool(_animationWheelNumber[i], true);

                    if (i == _positionAnimation[0])
                    {
                        _prize = 2500;
                    }

                    else if ((i == _positionAnimation[1]) || (i == _positionAnimation[5]))
                    {
                        _prize = 1000;
                    }

                    else if ((i == _positionAnimation[3]) || (i == _positionAnimation[7]) || (i == _positionAnimation[9]))
                    {
                        _prize = 2000;
                    }

                    else if ((i == _positionAnimation[2]) || (i == _positionAnimation[4]) || (i == _positionAnimation[6]) || (i == _positionAnimation[8]))
                    {
                        _prize = 1500;
                    }
                }
                else
                {
                    _animator.SetBool(_animationWheelNumber[i], false);
                }
            }
        }
    }

    private void UnlockButtonSpin(bool _blockButton)
    {
        _blockButtonSpin = _blockButton;
    }
}