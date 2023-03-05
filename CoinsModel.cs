using UnityEngine;
using UnityEngine.Analytics;

public class CoinsModel : MonoBehaviour
{
    private CoinsDebugUIPresenter _coinsPresenter;

    public int Amount;

    private void Awake()
    {
        Amount = PlayerPrefs.GetInt("Coins", 0);
    }

    public void OnPickupCoin()
    {
        Amount++;
        PlayerPrefs.SetInt("Coins", Amount);
    }

    public bool TryDiscard(int price)
    {
        if (Amount < price)
            return false;

        Amount -= price;

        _coinsPresenter.Render.text = $"Coins: {Amount}";
        _coinsPresenter.Animator.SetTrigger("OnPickupCoin");
        PlayerPrefs.SetInt("Coins", Amount);

        return true;
    }
}
