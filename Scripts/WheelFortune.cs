using UnityEngine;

[RequireComponent(typeof(Animator))]
public class WheelFortune : MonoBehaviour
{
    private readonly string _2500�oins = "_2500�oins";
    private readonly string _first1000�oins = "_first1000�oins";
    private readonly string _first1500�oins = "_first1500�oins";
    private readonly string _first2000�oins = "_first2000�oins";
    private readonly string _fourth1500�oins = "_fourth1500�oins";
    private readonly string _second1000�oins = "_second1000�oins";
    private readonly string _second1500�oins = "_second1500�oins";
    private readonly string _second2000coins = "_second2000coins";
    private readonly string _third1500�oins = "_third1500�oins";
    private readonly string _third2000�oins = "_third2000�oins";
    private readonly string[] _animationNumber = {"_2500�oins", "_first1000�oins", "_first1500�oins", "_first2000�oins",
    "_fourth1500�oins", "_second1000�oins", "_second1500�oins", "_second2000coins", "_third1500�oins", "_third2000�oins"};
    //private readonly string[] _animationNumber = {_2500�oins, "_first1000�oins", "_first1500�oins", "_first2000�oins",
    //"_fourth1500�oins", "_second1000�oins", "_second1500�oins", "_second2000coins", "_third1500�oins", "_third2000�oins"};
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
            Debug.Log("�������! - rand = " + rand);
        }
        else
        {
            _animator.SetBool(_animationNumber[i], false);
            Debug.Log("�������! - rand = " + rand);
        }
    }
}