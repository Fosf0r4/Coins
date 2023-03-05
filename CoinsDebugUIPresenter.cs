using UnityEngine;
using UnityEngine.UI;

public class CoinsDebugUIPresenter : MonoBehaviour
{
    [SerializeField] public Text Render;
    [SerializeField] public Animator Animator;

    private CoinsModel _model;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
        {
            _model.OnPickupCoin();

            Render.text = $"Coins: {_model.Amount}";
            Animator.SetTrigger("OnPickupCoin");
        }
       
    }
}
