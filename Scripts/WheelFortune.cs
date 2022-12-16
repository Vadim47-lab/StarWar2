using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class WheelFortune : MonoBehaviour
{
    [SerializeField] private TMP_Text _textCoins;
    [SerializeField] private GameObject _coins;

    private readonly int[] _positionAnimation = { 0, 1, 2, 3, 5, 6, 7, 8, 9 };
    private readonly string[] _animationNumber = {"_2500Ñoins", "_first1000Ñoins", "_first1500Ñoins", "_first2000Ñoins",
    "_fourth1500Ñoins", "_second1000Ñoins", "_second1500Ñoins", "_second2000coins", "_third1500Ñoins", "_third2000Ñoins"};
    private int _rand;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SpinWheelFortune()
    {
        int prize;
        _rand = Random.Range(0, 9);

        for (int i = 0; i < _animationNumber.Length; i++)
        {
            if (_rand == i)
            {
                _animator.SetBool(_animationNumber[i], true);

                if (i == _positionAnimation[0])
                {
                    Debug.Log("1");
                    prize = 2500;
                    ShowCoins(prize);
                }

                else if ((i == _positionAnimation[1]) || (i == _positionAnimation[5]))
                {
                    Debug.Log("2, 6");
                    prize = 1000;
                    ShowCoins(prize);
                }

                else if ((i == _positionAnimation[2]) || (i == _positionAnimation[4]) || (i == _positionAnimation[6]) || (i == _positionAnimation[8]))
                {
                    Debug.Log("3, 5, 7, 9");
                    prize = 1500;
                    ShowCoins(prize);
                }

                else if ((i == _positionAnimation[3]) || (i == _positionAnimation[7]) || (i == _positionAnimation[9]))
                {
                    Debug.Log("4, 8, 10");
                    prize = 2000;
                    ShowCoins(prize);
                }
            }
            else
            {
                _animator.SetBool(_animationNumber[i], false);
            }
        }
    }

    public void ShowCoins(int prize)
    {


        _coins.SetActive(true);
        _textCoins.text = "" + prize;
    }
}