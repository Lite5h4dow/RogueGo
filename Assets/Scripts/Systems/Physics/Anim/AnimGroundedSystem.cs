﻿using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  public class AnimGroundedSystem : ComponentSystem {
    EntityQuery player;

    protected override void OnCreateManager () {
      player = GetEntityQuery(
        typeof(Player),
        typeof(CollidedWithGround),
        typeof(Animator)
      );
    }

    protected override void OnUpdate () {
      Entities.With(player).ForEach((Animator anim) => {
        anim.SetBool("isGrounded", true);
      });
    }
  }
}