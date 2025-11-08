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
        
        DebugTimeAndCount();
        
        if (_timer._isDone && _wallet.Value < _cout)
        {
            Lose();
        }
        else if (_wallet.Value >= _cout)
        {
            Win();
        }
    }

    public void Restart()
    {
        _timer.Reset();
        _wallet.Reset();
    }

    private void Win()
    {
        Debug.Log("You won!");
    }

    private void Lose()
    {
        Debug.Log("Lose");
    }

    private void DebugTimeAndCount()
    {
        Debug.Log($"Time: {_timer._currentTime}");
        Debug.Log($"Cout: {_wallet.Value}/{_cout}");
    }
}
