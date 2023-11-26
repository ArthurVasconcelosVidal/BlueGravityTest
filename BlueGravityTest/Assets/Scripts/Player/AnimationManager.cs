using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour{

    public enum ClothesAnimations{A0_IdleTree, A1_IdleTree}
    [SerializeField] Animator playerAnimator;
    [SerializeField] Animator clothesAnimator;

    public Animator PlayerAnimator { get => playerAnimator; }
    public Animator ClothesAnimator { get => clothesAnimator; }

    public Vector2 Axis {
        private get => Vector2.zero;
        set {
            playerAnimator.SetFloat("X", value.x);
            playerAnimator.SetFloat("Y", value.y);
            clothesAnimator.SetFloat("X", value.x);
            clothesAnimator.SetFloat("Y", value.y);
        }
    }

    public bool IsMoving {
        private get => false;
        set {
            playerAnimator.SetBool("isMoving", value);
            clothesAnimator.SetBool("isMoving", value);
        }
    }

    public void PlayClothesAnimation(string animationName){
        ClothesAnimator.Play(animationName);
    }

}
