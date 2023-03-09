using UnityEngine;

public class Root : MonoBehaviour
{
    private CoinsDebugUIPresenter _coinsPresenter;
    private CoinsModel _coinsModel;

    public CoinsDebugUIPresenter CoinsPresenter => _coinsPresenter;
    public CoinsModel CoinsModel => _coinsModel;

    private void Awake()
    {
        _coinsPresenter = new CoinsDebugUIPresenter();
        _coinsModel = new CoinsModel();

        _coinsModel.OnPickupCoin();
        Debug.Log(_coinsModel.Amount);

    }
}
