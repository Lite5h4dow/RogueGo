using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  public class AnimSwordUnequippedSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player),
        ComponentType.Exclude(typeof(SwordDrawn)),
        typeof(Grounded),
        typeof(Animator)
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach((Animator anim) => {
        anim.SetBool("swordDrawn", false);
      });
    }
  }
}