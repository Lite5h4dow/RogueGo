using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

using UnityEngine;

namespace RogueGo {
  public class DodgeTimerDecremrntSystem : ComponentSystem {
    EntityQuery timer;

    protected override void OnCreateManager() {
      timer = GetEntityQuery(
        typeof(Dodging)
      );
    }

    protected override void OnUpdate() {
      Entities.With(timer).ForEach((ref Dodging dodging) => {
        dodging.Value -= Time.deltaTime;
      });
    }
  }
}