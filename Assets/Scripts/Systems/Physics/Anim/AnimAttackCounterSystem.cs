using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class AnimAttackCounterSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager() {
      player = GetEntityQuery(
        typeof(Player),
        typeof(AttackCounter),
        typeof(Animator)
      );
    }

    protected override void OnUpdate() {
      Entities.With(player).ForEach((Animator anim, ref AttackCounter ac) => {
        anim.SetInteger("attackCounter", ac.Value);
      });
    }
  }
}