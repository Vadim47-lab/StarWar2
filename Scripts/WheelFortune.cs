using TMPro;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class WheelFortune : MonoBehaviour
{
    [SerializeField] private TMP_Text _textCoins;
    [SerializeField] private GameObject _coins;

    private readonly int[] _positionAnimation = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private readonly string[] _animationNumber = {"_2500Ñoins", "_first1000Ñoins", "_first1500Ñoins", "_first2000Ñoins",
    "_fourth1500Ñoins", "_second1000Ñoins", "_second1500Ñoins", "_second2000coins", "_third1500Ñoins", "_third2000Ñoins"};
    private int _randomAnimation;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SpinWheelFortune()
    {
        int prize;
        _randomAnimation = Random.Range(0, 9);

        for (int i = 0; i < _animationNumber.Length; i++)
        {
            if (_randomAnimation == i)
            {
                _animator.SetBool(_animationNumber[i], true);

                if (i == _positionAnimation[0])
                {
                    prize = 2500;
                    ShowCoins(prize);
                }

                else if ((i == _positionAnimation[1]) || (i == _positionAnimation[5]))
                {
                    prize = 1000;
                    ShowCoins(prize);
                }

                else if ((i == _positionAnimation[3]) || (i == _positionAnimation[7]) || (i == _positionAnimation[9]))
                {
                    prize = 2000;
                    ShowCoins(prize);
                }

                else if ((i == _positionAnimation[2]) || (i == _positionAnimation[4]) || (i == _positionAnimation[6]) || (i == _positionAnimation[8]))
                {
                    prize = 1500;
                    ShowCoins(prize);
                }
            }
            else
            {
                _animator.SetBool(_animationNumber[i], false);
            }
        }
    }

    private void ShowCoins(int prize)
    {
        _coins.SetActive(true);
        _textCoins.text = "" + prize;
    }
}