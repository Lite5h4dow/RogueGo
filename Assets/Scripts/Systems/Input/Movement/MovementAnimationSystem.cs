using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  public class MovementAnimationSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery (
        typeof (Player),
        typeof (Animator),
        typeof (MovementInput)
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach((Animator anim, ref MovementInput move) => {
        anim.SetBool("isRunning", (move.Value != 0));
      });
    }
  }
}