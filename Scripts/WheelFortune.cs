using UnityEngine;

[RequireComponent(typeof(Animator))]
public class WheelFortune : MonoBehaviour
{
    private readonly string _2500Ñoins = "_2500Ñoins";
    private readonly string _first1000Ñoins = "_first1000Ñoins";
    private readonly string _first1500Ñoins = "_first1500Ñoins";
    private readonly string _first2000Ñoins = "_first2000Ñoins";
    private readonly string _fourth1500Ñoins = "_fourth1500Ñoins";
    private readonly string _second1000Ñoins = "_second1000Ñoins";
    private readonly string _second1500Ñoins = "_second1500Ñoins";
    private readonly string _second2000coins = "_second2000coins";
    private readonly string _third1500Ñoins = "_third1500Ñoins";
    private readonly string _third2000Ñoins = "_third2000Ñoins";
    private readonly string[] _animationNumber = {"_2500Ñoins", "_first1000Ñoins", "_first1500Ñoins", "_first2000Ñoins",
    "_fourth1500Ñoins", "_second1000Ñoins", "_second1500Ñoins", "_second2000coins", "_third1500Ñoins", "_third2000Ñoins"};
    //private readonly string[] _animationNumber = {_2500Ñoins, "_first1000Ñoins", "_first1500Ñoins", "_first2000Ñoins",
    //"_fourth1500Ñoins", "_second1000Ñoins", "_second1500Ñoins", "_second2000coins", "_third1500Ñoins", "_third2000Ñoins"};
    private int rand;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SpinWheelFortune()
    {
        rand = Random.Range(0, 9);

        for (int i = 0; i < _animationNumber.Length; i++)
        if (rand == i)
        {
            _animator.SetBool(_animationNumber[i], true);
            Debug.Log("óñïåøíî! - rand = " + rand);
        }
        else
        {
            _animator.SetBool(_animationNumber[i], false);
            Debug.Log("óñïåøíî! - rand = " + rand);
        }
    }
}