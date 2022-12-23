using TMPro;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class WheelFortune : MonoBehaviour
{
    [SerializeField] private TMP_Text _textCoins;
    [SerializeField] private GameObject _coins;

    private Animator _animator;
    private readonly string[] _animationWheelNumber = {"_2500Ñoins", "_first1000Ñoins", "_first1500Ñoins", "_first2000Ñoins",
    "_fourth1500Ñoins", "_second1000Ñoins", "_second1500Ñoins", "_second2000coins", "_third1500Ñoins", "_third2000Ñoins"};
    private readonly string[] _animationCoinNumber = {"_2500Ñoins", "_first1000Ñoins", "_first1500Ñoins", "_first2000Ñoins",
    "_fourth1500Ñoins", "_second1000Ñoins", "_second1500Ñoins", "_second2000coins", "_third1500Ñoins", "_third2000Ñoins"};
    private readonly int[] _positionAnimation = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private int _randomAnimation;
    private int _prize;
    private readonly float _seconds = 5;
    private float _gameSeconds;
    private bool _startTime;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_startTime == true)
        {
            _gameSeconds = _gameSeconds + Time.deltaTime + .0f;

            if (_gameSeconds >= _seconds)
            {
                ShowCoins();
            }
        }
    }

    public void SpinWheelFortune()
    {
        _coins.SetActive(false);
        _startTime = false;
        _randomAnimation = Random.Range(0, 9);

        for (int i = 0; i < _animationWheelNumber.Length; i++)
        {
            if (_randomAnimation == i)
            {
                _startTime = true;
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

    private void ShowCoins()
    {
        _coins.SetActive(true);
        _textCoins.text = "" + _prize;
        _gameSeconds = 0;
        _startTime = false;
    }
}