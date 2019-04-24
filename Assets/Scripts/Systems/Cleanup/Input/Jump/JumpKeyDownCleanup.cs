﻿using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace RogueGo {
  [UpdateInGroup(typeof(CleanupGroup))]
  public class JumpKeyDownCleanup : ComponentSystem {
    EntityQuery key;

    protected override void OnCreateManager () {
      key = GetEntityQuery (
        typeof (JumpKeyDown)
      );
    }

    protected override void OnUpdate () {
      Entities.With(key).ForEach(entity =>{
        PostUpdateCommands.RemoveComponent<JumpKeyDown>(entity);
      });
    }
  }
}