using _Game.Scripts;
using UnityEngine;

public class GameRules : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;
    private Timer _timer;

    [SerializeField] private float _time;
    [SerializeField] private int _cout;

    private void Awake()
    {
        _timer = new Timer(_time);
    }

    private void Update()
    {
        _timer.Update();

        if (_timer._isDone && _wallet.Value < _cout)
        {
            Lose();
        }
        
        if (_wallet.Value >= _cout)
        {
            Win();            
        }
    }

    private void Win()
    {
        Debug.Log("You won!");
    }

    private void Lose()
    {
        Debug.Log("Lose");
    }
}
