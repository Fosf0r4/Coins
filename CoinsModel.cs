using UnityEngine;

public class CoinsModel 
{
    private Root _init;

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

        _init.CoinsPresenter.Render.text = $"Coins: {Amount}";
        _init.CoinsPresenter.Animator.SetTrigger("OnPickupCoin");
        PlayerPrefs.SetInt("Coins", Amount);

        return true;
    }
}
