using UnityEngine;
using UnityEngine.UI;

public class CoinsDebugUIPresenter : MonoBehaviour
{
    [SerializeField] public Text Render;
    [SerializeField] public Animator Animator;

    private Root _init;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
        {
            _init.CoinsModel.OnPickupCoin();

            Render.text = $"Coins: {_init.CoinsModel.Amount}";
            Animator.SetTrigger("OnPickupCoin");
        }  
    }
}
